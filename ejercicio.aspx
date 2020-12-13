<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio.aspx.cs" Inherits="ejercicio3.ejercicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="CONVERTIR DE BINARIO A OCTAL"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Digite un numero binario:  "></asp:Label>
            <asp:TextBox ID="txtValor" runat="server" OnTextChanged="txtValor_TextChanged" Width="173px" style="height: 22px"></asp:TextBox>
            <asp:Button ID="btnConvertir" runat="server" OnClick="btnConvertir_Click" Text="Convertir" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Numero binario completado a ternas:  "></asp:Label>
            <asp:TextBox ID="txtTerna" runat="server" OnTextChanged="txtTerna_TextChanged" Width="317px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Ternas encontradas"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 374px; top: 242px; position: absolute; width: 218px" Text="Valor de la terna"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="listValTerna" runat="server" AutoPostBack="True" Height="166px" OnSelectedIndexChanged="listValTerna_SelectedIndexChanged" SelectionMode="Multiple" style="z-index: 1; left: 379px; top: 280px; position: absolute; width: 137px"></asp:ListBox>
            <br />
            <asp:ListBox ID="listTernas" runat="server" AutoPostBack="True" Height="155px" OnSelectedIndexChanged="listTernas_SelectedIndexChanged1" SelectionMode="Multiple" Width="144px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="El numero binario convertido a octal es:  "></asp:Label>
            <asp:TextBox ID="txtSalida" runat="server" OnTextChanged="txtSalida_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
