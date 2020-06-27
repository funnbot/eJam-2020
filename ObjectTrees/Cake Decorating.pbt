Name: "Cake Decorating"
RootId: 14987741691391332549
Objects {
  Id: 11901760667542837737
  Name: "Cake Base"
  Transform {
    Location {
    }
    Rotation {
    }
    Scale {
      X: 1
      Y: 1
      Z: 1
    }
  }
  ParentId: 14987741691391332549
  ChildIds: 14005056925617517116
  Collidable_v2 {
    Value: "mc:ecollisionsetting:inheritfromparent"
  }
  Visible_v2 {
    Value: "mc:evisibilitysetting:inheritfromparent"
  }
  Folder {
    IsGroup: true
  }
}
Objects {
  Id: 14005056925617517116
  Name: "Chocolate Cake Base"
  Transform {
    Scale {
      X: 1
      Y: 1
      Z: 1
    }
  }
  ParentId: 11901760667542837737
  Collidable_v2 {
    Value: "mc:ecollisionsetting:inheritfromparent"
  }
  Visible_v2 {
    Value: "mc:evisibilitysetting:inheritfromparent"
  }
  TemplateInstance {
    ParameterOverrideMap {
      key: 11107915909810766948
      value {
        Overrides {
          Name: "Name"
          String: "Chocolate Cake Base"
        }
        Overrides {
          Name: "Position"
          Vector {
            X: -550
            Y: -550
            Z: 50
          }
        }
      }
    }
    TemplateAsset {
      Id: 17049311476643076148
    }
  }
}
