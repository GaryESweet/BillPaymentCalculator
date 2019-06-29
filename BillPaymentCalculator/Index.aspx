<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BillPaymentCalculator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Name">
            <label for="BusinessNameInput" runat="server">Business Name:</label>
            <input runat="server" id="BusinessNameInput" />
            <asp:Button runat="server" ID="BusinessName" OnClick="BusinessName_Click" Text="Save Name" />
        </div>
        <div id="Payment">
            <label for="MonthlyPaymentLabel" runat="server">Monthly Payment Amount:</label>
            <input runat="server" id="MonthlyPaymentInput" />
            <label>Is this payment active?</label>
            <input type="radio" name="IsActive" id="IsActiveYes" value="Yes" checked="checked"/>
            <label for="IsActiveYes">Yes</label>
            <input type="radio" name="IsActive" id="IsActiveNo" value="No"/>
            <label for="IsActiveNo">No</label>
            <asp:Button runat="server" ID="btnMonthlyPayment" OnClick="btnMonthlyPayment_Click" Text="Save Payment"/>
        </div>
        <div id="Seed">
            <label for="BusinessNameInput" runat="server">Seed Amount:</label>
            <input runat="server" id="Text1" />
            <asp:Button runat="server" ID="Button1" OnClick="BusinessName_Click" Text="Save Name" />
        </div>
    </form>
</body>
</html>
