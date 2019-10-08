<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus2WeeklyCalendar.aspx.cs" Inherits="n01378530_BonusAssignment_Timothy.Bonus2WeeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment Two - Weekly Calendar</title>
    <link rel="stylesheet" type="text/css" href="Content/Site.css" />
</head>
<body>
    <form id="form1" runat="server">

        <section>
            <h2>Please choose your work days:</h2>
            <asp:CheckBoxList runat="server" ID="client_weekly_schedule">
                <asp:ListItem Value="1" Text="Monday"></asp:ListItem>
                <asp:ListItem Value="2" Text="Tuesday"></asp:ListItem>
                <asp:ListItem Value="3" Text="Wednesday"></asp:ListItem>
                <asp:ListItem Value="4" Text="Thursday"></asp:ListItem>
                <asp:ListItem Value="5" Text="Friday"></asp:ListItem>
                <asp:ListItem Value="6" Text="Saturday"></asp:ListItem>
                <asp:ListItem Value="7" Text="Sunday"></asp:ListItem>
            </asp:CheckBoxList>
        </section>

        <section>
            <asp:Button runat="server" Text="submit" />
        </section>

        <section>
            <h2>Your Calendar</h2>
            <div runat="server" id="client_calendar"></div>
        </section>

    </form>
</body>
</html>
