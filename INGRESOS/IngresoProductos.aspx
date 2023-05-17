<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoProductos.aspx.cs" Inherits="INGRESOS.IngresoProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

        <style>
        * {
            padding: 0;
            margin: 0;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 50vh;
        }

        .principal {
            text-align: center;
            align-items: center;
        }

        .input-box {
            display: flex;
            justify-content: space-between;
        }

            .input-box label {
                margin: 0 150px;
            }

        h2 {
            text-align: center;
        }
    </style>

    <form id="form1" runat="server">
        
                <div class="principal">
            <h2>INGRESE PRODUCTOS</h2>
            <br />
            <asp:Label ID="lblcorrecto" runat="server" Text="LA INSERCION FUE CORRECTA" Visible="false"></asp:Label>
            <asp:Label ID="lblerror" runat="server" Text="LA INSERCION FUE INCORRECTA" Visible="false"></asp:Label>
            <br />
            <div class="input-box">
                <asp:Label ID="lblnombre" runat="server" Text="NOMBRE DEL PRODUCTO"></asp:Label>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lbldescripcion" runat="server" Text="DESCRIPCION"></asp:Label>
                <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblcantidad" runat="server" Text="CANTIDAD"></asp:Label>
                <asp:TextBox ID="txtcantidad" runat="server" Onkeypress="return isNumberKey(evt)"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblprecio" runat="server" Text="PRECIO"></asp:Label>
                <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblcategoria" runat="server" Text="CATEGORIA"></asp:Label>
                <asp:DropDownList ID="ddlcategoria" runat="server">
                    <asp:ListItem Text="BEBIDA GASEOSA" Value="1"></asp:ListItem>
                    <asp:ListItem Text="LACTEOS" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div class="btx">
                <asp:Button ID="btnguardarproducto" runat="server" Text="GUARDAR" OnClick="Btnguardarproducto_Click"/>
            </div>
        </div>

    </form>
</body>
</html>
