<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus1Coordinate.aspx.cs" Inherits="n01378530_BonusAssignment_Timothy.Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment One - Coordinate</title>
    <link rel="stylesheet" type="text/css" href="Content/Site.css" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Please input two non-zero integer numbers here as a point on cartesian plane</h1>

            <div>
                <label>X-AXIS: </label>
                <asp:TextBox runat="server" ID="x_axis"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="x_axis" ValidationExpression="-?[0-9]+" EnableClientScript="true" ErrorMessage="Please input a valid integer number"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="x_axis" EnableClientScript="true" ErrorMessage="Please input number for X axis"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label>Y-AXIS: </label>
                <asp:TextBox runat="server" ID="y_axis"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="y_axis" ValidationExpression="-?[0-9]+" EnableClientScript="true" ErrorMessage="Please input a valid integer number"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="y_axis" EnableClientScript="true" ErrorMessage="Please input number for Y axis"></asp:RequiredFieldValidator>
            </div>
        </section>

        <section>
            <h2>Summary Section</h2>
            <asp:ValidationSummary runat="server" ShowSummary="true" />
            <div runat="server" id="result_summary"></div>
        </section>

        <section>
            <asp:Button runat="server" Text="submit" />
        </section>
    </form>
</body>
</html>
