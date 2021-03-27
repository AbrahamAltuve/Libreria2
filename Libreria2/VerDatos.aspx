<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerDatos.aspx.cs" Inherits="Libreria2.VerDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="LabelIdentificacion" runat="server" Text="IDENTIFICACION"></asp:Label>
            <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="LINQ"></asp:Label>
            <asp:GridView ID="gridViewLinQ" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="identificacion" HeaderText="IDENTIFICACION" />
                    <asp:BoundField DataField="razonSocial" HeaderText="razonSocial" />
                    <asp:BoundField DataField="direccion" HeaderText="direccion" />
                    <asp:BoundField DataField="telefono" HeaderText="telefono" />
                    <asp:BoundField DataField="correoContacto" HeaderText="correoContacto" />
                    <asp:BoundField DataField="represemtanteLegal" HeaderText="represemtanteLegal" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="Label4" runat="server" Text="ADO.NET"></asp:Label>
            <asp:GridView ID="gridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ServicioAdo">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="identificacion" HeaderText="identificacion" SortExpression="identificacion" />
                    <asp:BoundField DataField="razonSocial" HeaderText="razonSocial" SortExpression="razonSocial" />
                    <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
                    <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
                    <asp:BoundField DataField="correoContacto" HeaderText="correoContacto" SortExpression="correoContacto" />
                    <asp:BoundField DataField="represemtanteLegal" HeaderText="represemtanteLegal" SortExpression="represemtanteLegal" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="ServicioAdo" runat="server" ConnectionString="<%$ ConnectionStrings:ventasConnectionString %>" SelectCommand="SELECT * FROM [empresa]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
