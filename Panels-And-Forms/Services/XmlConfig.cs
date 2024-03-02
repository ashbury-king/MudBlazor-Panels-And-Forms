namespace Panels_And_Forms.Services;

public static class XmlConfig
{
    public static string Data()
    {
        return @"<root>
            <Alabama>
                <FirstName>Alice</FirstName>
                <MiddleName>Marie</MiddleName>
                <LastName>Johnson</LastName>
                <City>
                    <Name>Birmingham</Name>
                    <AreaCode>205</AreaCode>
                </City>
            </Alabama>
            <Alabama>
                <FirstName>David</FirstName>
                <MiddleName>Michael</MiddleName>
                <LastName>Thompson</LastName>
                <City>
                    <Name>Mobile</Name>
                    <AreaCode>251</AreaCode>
                </City>
            </Alabama>
            <Florida>
                <FirstName>Emily</FirstName>
                <MiddleName>Ann</MiddleName>
                <LastName>Wilson</LastName>
            </Florida>
            <Illinois>
                <FirstName>John</FirstName>
                <MiddleName>Patrick</MiddleName>
                <LastName>O'Malley</LastName>
                <City>
                    <Name>Chicago</Name>
                    <AreaCode>312</AreaCode>
                </City>
            </Illinois>
        </root>";
    }
}