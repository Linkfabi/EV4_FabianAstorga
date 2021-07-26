<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerPunto.aspx.cs" Inherits="EstacionesWeb.VerPunto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="mt-5">

         <asp:DropDownList ID="nivelDdl" AutoPostBack="true" runat="server"
                    OnSelectedIndexChanged="select_SelectedIndexChanged" Enabled="true">
                    <asp:ListItem Value="1" Selected="True" Text="Mostrar Todo"></asp:ListItem>
                    <asp:ListItem Value="Electrica" Text="Electrica"></asp:ListItem>
                    <asp:ListItem Value="Bencina" Text="Bencina"></asp:ListItem>
                </asp:DropDownList>

                <asp:GridView ID="PuntoGrid" runat="server" AutoGenerateColumns="false"
                    EmptyDataText="No hay Puntos de Carga" CssClass="table table-hover" OnRowCommand="puntoGrid_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="NumeroPuntoDeCarga" />
                        <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                        <asp:BoundField HeaderText="Region" DataField="Region" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button runat="server" Text="Eliminar"
                                    CssClass="btn btn-danger" CommandName="eliminar"
                                    CommandArgument='<%# Eval("NumeroPuntoDeCarga") %>'></asp:Button>
                                 <asp:Button runat="server" Text="Actualizar"
                                    CssClass="btn btn-warning" CommandName="actualizar"
                                    CommandArgument='<%# Eval("NumeroPuntoDeCarga") %>'></asp:Button>
                                 
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>


</asp:Content>
