<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bankAcount.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <label>Titular</label>
                    <asp:TextBox ID="txtTitular" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnTitular" runat="server" Text="Registrar" CssClass="form-control" OnClick="btnTitular_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">
                    <label>saldo</label>
                    <asp:TextBox ID="txtSaldo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">
                    <label>Transferir</label>
                    <asp:TextBox ID="txtTransf" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnTransfere" runat="server" Text="Enviar" CssClass="form-control" OnClick="btnTransfere_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">
                   <asp:Label ID="lblMsg" runat="server" CssClass="text-danger"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">
                    <label>Tributos</label>
                    <asp:TextBox ID="txtTributo" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnTributo" runat="server" Text="Enviar" CssClass="form-control" OnClick="btnTributo_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
