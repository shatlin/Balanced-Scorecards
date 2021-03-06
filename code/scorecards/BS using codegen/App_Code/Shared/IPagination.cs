
using Microsoft.VisualBasic;
  
namespace BS.UI
{

  

    public interface IPagination {

#region Interface Properties
        
        System.Web.UI.WebControls.TextBox CurrentPage {get;}
                
        System.Web.UI.WebControls.ImageButton FirstPage {get;}
                
        System.Web.UI.WebControls.ImageButton LastPage {get;}
                
        System.Web.UI.WebControls.ImageButton NextPage {get;}
                
        System.Web.UI.WebControls.TextBox PageSize {get;}
                
        System.Web.UI.WebControls.LinkButton PageSizeButton {get;}
                
        System.Web.UI.WebControls.ImageButton PreviousPage {get;}
                
        System.Web.UI.WebControls.Label TotalItems {get;}
                
        System.Web.UI.WebControls.Label TotalPages {get;}
                

#endregion

    }

  
}
  