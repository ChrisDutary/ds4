<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablaMultiplicar.aspx.cs" Inherits="Laboratorio201.TablaMultiplicar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicar</title>
    <style>
        .container {
            width: 50%;
            margin: 20px auto;
            padding: 20px;
            font-family: Arial, sans-serif;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            border-radius: 5px;
        }
        .resultado {
            margin-top: 20px;
            padding: 10px;
            background-color: #f8f9fa;
            border-radius: 5px;
        }
        .error {
            color: #dc3545;
            margin-top: 10px;
            font-size: 0.9em;
        }
        .input-group {
            margin: 15px 0;
        }
        .btn-generar {
            background-color: #007bff;
            color: white;
            padding: 5px 15px;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }
        .btn-generar:hover {
            background-color: #0056b3;
        }
        .form-control {
            padding: 5px;
            margin: 0 10px;
            border: 1px solid #ced4da;
            border-radius: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Tabla de Multiplicar</h2>
            <div class="input-group">
                <asp:Label ID="lblNumero" runat="server" Text="Ingrese un número (1-25):"></asp:Label>
                <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" type="number" min="1" max="25"></asp:TextBox>
                <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" CssClass="btn-generar" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            <div class="resultado">
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>