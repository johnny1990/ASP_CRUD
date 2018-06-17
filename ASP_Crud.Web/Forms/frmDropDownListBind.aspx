<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDropDownListBind.aspx.cs" Inherits="ASP_Crud.Web.Forms.frmDropDownListBind" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <asp:DropDownList ID="DropDownList1" runat="server">  
        </asp:DropDownList>  
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
        <br />  
        <br />  
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" Style="height: 26px" />  
        <br />  
        <br />  
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999"  
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">  
            <AlternatingRowStyle BackColor="#DCDCDC" />  
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />  
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />  
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />  
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#F1F1F1" />  
            <SortedAscendingHeaderStyle BackColor="#0000A9" />  
            <SortedDescendingCellStyle BackColor="#CAC9C9" />  
            <SortedDescendingHeaderStyle BackColor="#000065" />  
        </asp:GridView>  
    </div>  
    </form>  
</body>  
</html> 
</html>
