<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BillPaymentCalculator.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="BusinessNameInput" runat="server">Business Name:</label>
            <input runat="server" id="BusinessNameInput" />
            <asp:Button runat="server" ID="BusinessName" OnClick="BusinessName_Click" />
        </div>
        <div>
            <label for="MonthlyPaymentLabel" runat="server">Monthly Payment Amount:</label>
            <input runat="server" id="Text1" />
            <asp:Button runat="server" ID="btnMonthlyPayment" OnClick="btnMonthlyPayment_Click" />
        </div>
    </form>
</body>
</html>
