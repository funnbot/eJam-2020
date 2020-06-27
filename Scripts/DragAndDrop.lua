-- function to connect event handlers to ability events 
function ConnectAbilityEvents_DragAndDrop(ability)
	-- hooks on entering each phase
	ability.castEvent:Connect(OnCast_DragAndDrop)
	ability.executeEvent:Connect(OnExecute_DragAndDrop)
	
	ability.recoveryEvent:Connect(OnRecovery_DragAndDrop)
		
	ability.cooldownEvent:Connect(OnCooldown_DragAndDrop)
		
	ability.interruptedEvent:Connect(OnInterrupted_DragAndDrop)
		
	ability.readyEvent:Connect(OnReady_DragAndDrop)
		
	-- called each tick whenever ability is active
	ability.tickEvent:Connect(OnTick_DragAndDrop)
		
end

-- functions called when entering each phase. Add your code inside 
function OnCast_DragAndDrop(ability)
	print("OnCast " .. ability.name)
end

function OnExecute_DragAndDrop(ability)
	print("OnExecute " .. ability.name)
	
	-- if isTargetDataUpdated is set to true on ability phase, targetData can be used
	local targetData = ability:GetTargetData()
end

function OnRecovery_DragAndDrop(ability)
	-- print("OnRecovery " .. ability.name)
end

function OnCooldown_DragAndDrop(ability)
	-- print("OnCooldown " .. ability.name)
end

function OnInterrupted_DragAndDrop(ability)
	-- print("OnInterrupted " .. ability.name)
end

function OnReady_DragAndDrop(ability)
	-- print("OnReady " .. ability.name)
end

function OnTick_DragAndDrop(ability)
end


-- reference to ability object, modify as needed
local myAbility = script.parent

-- call to connect events to ability. 
-- this does not give the ability to player, that need to be handled separately depending on how ability is created in game
ConnectAbilityEvents_DragAndDrop(myAbility)

--------------------------------------------------------------------------------