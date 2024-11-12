<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._1._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


        <div class="row">  
            <div>
                <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
                    AllowSorting="True" AllowPaging="True"
                    DataKeyNames="ProductID"
                    AutoGenerateEditButton="True"
                    Runat="Server" />



                <asp:SqlDataSource id="MyDataSource1" runat="server"
                    ConnectionString="data Source=DESKTOP-539IR1D\SQLEXPRESS; initial catalog=northwind; persist security info=True;Integrated Security=SSPI;"
                    ProviderName="System.Data.SqlClient"
                    SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"
                    UpdateCommand="UPDATE Products SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductID]=@ProductID">
                </asp:SqlDataSource>


            </div>
        </div>


</asp:Content>
