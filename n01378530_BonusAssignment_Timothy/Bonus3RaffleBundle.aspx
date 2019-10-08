<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus3RaffleBundle.aspx.cs" Inherits="n01378530_BonusAssignment_Timothy.Bonus3RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment Three - Raffle Bundle</title>
    <link rel="stylesheet" type="text/css" href="Content/Site.css" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Number of tickets ordered:</h1>
            <asp:TextBox runat="server" ID="client_tickets_total"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="client_tickets_total" EnableClientScript="true" ErrorMessage="Please input the number of tickets"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="client_tickets_total" ValueToCompare="0" Operator="GreaterThan" Type="Integer" EnableClientScript="true" ErrorMessage="Please input a valid number"></asp:CompareValidator>
        </section>

        <section>
            <asp:Button runat="server" Text="submit" />
        </section>

        <section>
            <h2>Your Bundle Summary</h2>
            <div runat="server" id="bundle_summary"></div>
        </section>
    </form>
</body>
</html>
