<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductID" runat="server" Text="ProductID" width="89px"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDrinkType" runat="server" Text="Drink Type" width="89px"></asp:Label>
            <asp:TextBox ID="txtDrinkType" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="89px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="89px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateReceived" runat="server" Text="Date Received"></asp:Label>
        <asp:TextBox ID="txtDateReceived" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
&nbsp;<p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="36px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="margin-left: 0px" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
