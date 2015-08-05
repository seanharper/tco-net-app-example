<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>2Checkout Sample App</title>
    <link rel="stylesheet" href="css/styles.css" type="text/css" />
</head>
<body>
    <div id="wrapper">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="scriptmanager1" runat="server"></asp:ScriptManager>
            <div id="customer_form" class="forms" runat="server">
                <h3>Create a Customer</h3>
                <hr />
                <asp:Label ID="lbl_name" runat="server" Text="Name: " />
                <asp:TextBox ID="txt_name" runat="server" placeholder=" Type customer name " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_email" runat="server" Text="Email: " />
                <asp:TextBox ID="txt_email" runat="server" placeholder=" Type customer email " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_phone" runat="server" Text="Phone: " />
                <asp:TextBox ID="txt_phone" runat="server" placeholder=" Type customer phone " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_address" runat="server" Text="Address: " />
                <asp:TextBox ID="txt_address" runat="server" placeholder=" Type customer street address " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_city" runat="server" Text="City: " />
                <asp:TextBox ID="txt_city" runat="server" placeholder=" Type customer city " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_state" runat="server" Text="State: " />
                <asp:TextBox ID="txt_state" runat="server" placeholder=" Type customer state (Example: OH) " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_zip" runat="server" Text="ZipD: " />
                <asp:TextBox ID="txt_zip" runat="server" placeholder=" Type customer zip " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_country" runat="server" Text="Country code: " />
                <asp:TextBox ID="txt_country" runat="server" placeholder=" Type customer country code (Example: USA) " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_currency" runat="server" Text="Currency: " />
                <asp:TextBox ID="txt_currency" runat="server" placeholder=" Type customer currency " ></asp:TextBox>
                <br />
                <asp:Button ID="btn_customer_submit" runat="server" OnClick="btn_customer_submit_Click" />
            </div>

            <div id="pay_method_form" class="forms" runat="server">
                <h3>Add a Payment Method</h3>
                <hr />
                <asp:Button ID="btn_pay_method_submit" runat="server" OnClick="btn_pay_method_submit_Click" />
            </div>
            
            
            <div id="sale_form" class="forms" runat="server">
                <h3>Create a Sale</h3>
                <hr />
                <asp:Label ID="lbl_merchID" runat="server" Text="Merchant ID: " />
                <asp:TextBox ID="txt_merchID" runat="server" placeholder=" Type the merchant id " ></asp:TextBox>
                <br />
                <asp:Label ID="lbl_amount" runat="server" Text="Sale Amount: " />
                <asp:TextBox ID="txt_amount" runat="server" placeholder=" Type the sale amount "></asp:TextBox>
                <br />
                <asp:Button ID="btn_submit" runat="server" Text="Create Sale" OnClick="btn_submit_Click" />
            </div>
        </form>
    </div>
</body>
</html>
