<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProduse.aspx.cs" Inherits="ASP_Crud.Web.Forms.frmProduse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <strong><span class="auto-style1">Produse ASP Crud </span></strong>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 13px" Width="70px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div>

            Nume produs<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 17px" Width="265px"></asp:TextBox>
            <br />
            <br />

        </div>

        <div>

            Categorie<asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />

        </div>

        
        

        <div>

            Pret vanzare + TVA<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 24px" Width="215px"></asp:TextBox>

            <br />

        </div>

        <div>

            <br />
            Cantitate
            <asp:TextBox ID="TextBox5" runat="server" Width="137px"></asp:TextBox>

            <br />

        </div>

        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 401px" Text="Button" Width="371px" />

        </div>
    </form>
</body>
</html>
