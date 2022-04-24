
using Microsoft.VisualBasic;
  
namespace BS.UI
{

  

    public interface IMenu {

#region Interface Properties
        
        IMenu_Item MeasureMenuItem {get;}
                
        IMenu_Item_Highlighted MeasureMenuItemHilited {get;}
                
        IMenu_Item MeasureRoleDetailMenuItem {get;}
                
        IMenu_Item_Highlighted MeasureRoleDetailMenuItemHilited {get;}
                
        IMenu_Item MeasureTypeMenuItem {get;}
                
        IMenu_Item_Highlighted MeasureTypeMenuItemHilited {get;}
                
        IMenu_Item MonthMenuItem {get;}
                
        IMenu_Item_Highlighted MonthMenuItemHilited {get;}
                
        IMenu_Item ObjectiveMenuItem {get;}
                
        IMenu_Item_Highlighted ObjectiveMenuItemHilited {get;}
                
        IMenu_Item PerspectiveMenuItem {get;}
                
        IMenu_Item_Highlighted PerspectiveMenuItemHilited {get;}
                
        IMenu_Item RoleMeasureMenuItem {get;}
                
        IMenu_Item_Highlighted RoleMeasureMenuItemHilited {get;}
                
        IMenu_Item YearMenuItem {get;}
                
        IMenu_Item_Highlighted YearMenuItemHilited {get;}
                

#endregion

    }

  
}
  