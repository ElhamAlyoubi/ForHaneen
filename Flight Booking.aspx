<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Flight Booking.aspx.cs" Inherits="HARRE_agency.Flight_Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="title" aria-atomic="False">
                Book your flight</div>
            <p>
                <asp:Label ID="Label9" runat="server" Text="Trip Plan:"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList" runat="server" Height="20px" Width="135px" OnSelectedIndexChanged="RadioButtonList_SelectedIndexChanged">
                    <asp:ListItem>one-way</asp:ListItem>
                    <asp:ListItem>Round trip</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Label ID="lblWarning2" runat="server" ForeColor="Red" Text="Choose your trip plan" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <asp:Label ID="Label1" runat="server" Text="From: "></asp:Label>
            <asp:ListBox ID="listFrom" runat="server" AutoPostBack="True" Height="20px" OnSelectedIndexChanged="listFrom_SelectedIndexChanged" Rows="1" Width="225px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Riyadh, Saudi ArabiaRiyadh, Saudi Arabia</asp:ListItem>
                <asp:ListItem>Jeddah, Saudi ArabiaJeddah, Saudi Arabia</asp:ListItem>
                <asp:ListItem>Dammam, Saudi ArabiaDammam, Saudi Arabia</asp:ListItem>
                <asp:ListItem>New YorkNew York</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem>Rome</asp:ListItem>
                <asp:ListItem>Sydney</asp:ListItem>
                <asp:ListItem>Tokyo</asp:ListItem>
            </asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="To:"></asp:Label>
            &nbsp;<asp:ListBox ID="ListTo" runat="server" AutoPostBack="True" Height="20px" OnSelectedIndexChanged="ListTo_SelectedIndexChanged" Rows="1" Width="225px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Riyadh, Saudi ArabiaRiyadh, Saudi Arabia</asp:ListItem>
                <asp:ListItem>Jeddah, Saudi ArabiaJeddah, Saudi Arabia</asp:ListItem>
                <asp:ListItem>Dammam, Saudi ArabiaDammam, Saudi Arabia</asp:ListItem>
                <asp:ListItem>New YorkNew York</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem>Rome</asp:ListItem>
                <asp:ListItem>Sydney</asp:ListItem>
                <asp:ListItem>Tokyo</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWarning0" runat="server" ForeColor="Red" Text="Enter your trip details" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="flight day: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Departure day:"></asp:Label>
&nbsp;&nbsp;
            <asp:ListBox ID="ListMonth1" runat="server" AutoPostBack="True" Height="20px" Rows="1" Width="225px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>January</asp:ListItem>
                <asp:ListItem>February</asp:ListItem>
                <asp:ListItem>March</asp:ListItem>
                <asp:ListItem>April</asp:ListItem>
                <asp:ListItem>May</asp:ListItem>
                <asp:ListItem>June</asp:ListItem>
                <asp:ListItem>July</asp:ListItem>
                <asp:ListItem>August</asp:ListItem>
                <asp:ListItem>September</asp:ListItem>
                <asp:ListItem>October</asp:ListItem>
                <asp:ListItem>November</asp:ListItem>
                <asp:ListItem>December</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListDay1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListDay1_SelectedIndexChanged" Rows="1" Width="225px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem Value="29"></asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWarning3" runat="server" ForeColor="Red" Text="Enter departure day" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Return day:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListMonth2" runat="server" AutoPostBack="True" Height="20px" Rows="1" Width="225px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>January</asp:ListItem>
                <asp:ListItem>February</asp:ListItem>
                <asp:ListItem>March</asp:ListItem>
                <asp:ListItem>April</asp:ListItem>
                <asp:ListItem>May</asp:ListItem>
                <asp:ListItem>June</asp:ListItem>
                <asp:ListItem>July</asp:ListItem>
                <asp:ListItem>August</asp:ListItem>
                <asp:ListItem>September</asp:ListItem>
                <asp:ListItem>October</asp:ListItem>
                <asp:ListItem>November</asp:ListItem>
                <asp:ListItem>December</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListDay2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListDay2_SelectedIndexChanged" Rows="1" Width="225px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem Value="29"></asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWarning4" runat="server" ForeColor="Red" Text="Enter return day" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Class: "></asp:Label>
            <asp:ListBox ID="ListClass" runat="server" AutoPostBack="True" Height="22px" Rows="1" Width="225px">
                <asp:ListItem>Economy</asp:ListItem>
                <asp:ListItem>Premium Economy</asp:ListItem>
                <asp:ListItem>Business</asp:ListItem>
                <asp:ListItem>First</asp:ListItem>
            </asp:ListBox>
            &nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label4" runat="server" Text="Passengers: "></asp:Label>
            <asp:Label ID="NumPassengers" runat="server" Text="#num"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWarning1" runat="server" ForeColor="Red" Text="Enter number of passengers" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Adults:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAdults" runat="server" OnTextChanged="txtAdults_TextChanged">0</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Children:"></asp:Label>
&nbsp;<asp:TextBox ID="txtChildren" runat="server" OnTextChanged="txtChildren_TextChanged">0</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Infants:"></asp:Label>
&nbsp;<asp:TextBox ID="txtInfants" runat="server" OnTextChanged="txtInfants_TextChanged">0</asp:TextBox>
            <asp:Label ID="lblWarning" runat="server" ForeColor="Red" Text="Enter a valid number" Visible="False"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="Proceed" Width="138px" />
        </div>
        <p>
            &nbsp;&nbsp;<asp:Label ID="Label13" runat="server" Text="Select Ariport" Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="485px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Visible="False" Height="38px">
        </asp:RadioButtonList>
        <p>
            <asp:Label ID="LabelMessage" runat="server" Text="can not " Visible="False"></asp:Label>
        </p>
    <p>
        <asp:Table ID="Table1" runat="server" Width="1139px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Data</asp:TableCell>
                <asp:TableCell runat="server">Time</asp:TableCell>
                <asp:TableCell runat="server">Cost</asp:TableCell>
                <asp:TableCell runat="server">Airport names</asp:TableCell>
                <asp:TableCell runat="server">Destinations</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
            <asp:ListBox ID="ListBox1" runat="server" Height="84px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="1147px"></asp:ListBox>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
