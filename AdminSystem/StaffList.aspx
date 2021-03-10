<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<script runat="server">

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="595px" Width="470px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>
