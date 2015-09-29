﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageSpecialEvents.aspx.cs" Inherits="Admin_ManageSpecialEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Special Events
            <span class="glyphicon glyphicon-glass"></span>
        </h1>
    

    <!-- ObjectDataSource control to do the underlying communication with my BLL and my ListView Control -->
    <asp:ObjectDataSource ID="SpecialEventsDataSource" runat="server" TypeName="eRestaurant.Framework.Bll.RestaurantAdminController" SelectMethod="ListAllSpecialEvents" DataObjectTypeName="eRestaurant.Entities.SpecialEvent">
    </asp:ObjectDataSource>

    <%--<asp:GridView ID="SpecialEventsGridView" runat="server" DataSourceID="SpecialEventsDataSource"></asp:GridView>--%>

        <asp:ListView ID="SpecialEventsListView" runat="server" DataSourceID="SpecialEventsDataSource">
            <LayoutTemplate>
                <fieldset runat="server" id="itemPlaceholderContainer">
                    <div runat="server" id="itemPlaceholder" />
                </fieldset>
            </LayoutTemplate>

            <ItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Edit" ID="EditButton">Edit <span class="glyphicon glyphicon-plus"></span></asp:LinkButton>
                    &mdash;&mdash;
                    <asp:LinkButton runat="server" CommandName="Delete" ID="DeleteButton">Delete <span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                    &mdash;&mdash;&mdash;
                    <asp:CheckBox Checked='<%# Eval("Active") %>' runat="server" ID="ActiveCheckbox" Enabled="false" Text="Active" />
                    &mdash;
                    <asp:Label ID="Label1" runat="server" AssociatedControlID="EventCodeData" CssClass="control-label">Event Code</asp:Label>
                    <asp:Label ID="EventCodeData" runat="server" Text='<%#Eval("EventCode") %>' />
                    &mdash;
                    <asp:Label ID="Label2" runat="server" AssociatedControlID="DescriptionData" CssClass="control-label">Description</asp:Label>
                    <asp:Label ID="DescriptionData" runat="server" Text='<%# Eval("Description") %>' />
                </div>
            </ItemTemplate>

        </asp:ListView>
    </div>
</asp:Content>

