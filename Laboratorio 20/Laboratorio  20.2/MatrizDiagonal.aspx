<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatrizDiagonal.aspx.cs" Inherits="Laboratorio202.MatrizDiagonal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz NxN</title>
    <style>
        .container {
            width: 70%;
            margin: 20px auto;
            padding: 20px;
            font-family: Arial, sans-serif;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            border-radius: 5px;
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
        .error {
            color: #dc3545;
            margin-top: 10px;
        }
        .matriz-container {
            margin-top: 20px;
            overflow-x: auto;
        }
        .matriz {
            border-collapse: collapse;
            margin: 0 auto;
        }
        .matriz td {
            width: 40px;
            height: 40px;
            text-align: center;
            border: 1px solid #dee2e6;
        }
        .diagonal {
            background-color: #e9ecef;
            font-weight: bold;
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
            <h2>Generador de Matriz NxN</h2>
            <div class="input-group">
                <asp:Label ID="lblTamano" runat="server" Text="Ingrese el tamaño de la matriz (N):"></asp:Label>
                <asp:TextBox ID="txtTamano" runat="server" CssClass="form-control" type="number" min="2" max="10"></asp:TextBox>
                <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" CssClass="btn-generar" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
            <div class="matriz-container">
                <asp:Literal ID="litMatriz" runat="server"></asp:Literal>
            </div>
        </div>
    </form>
</body>
</html>