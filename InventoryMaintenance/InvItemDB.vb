Imports System.Xml

Public Class InvItemDB
    Private Const Path As String = "..\..\InventoryItems.xml"

    Public Shared Function GetItems() As List(Of InvItem)
        ' create the list
        Dim items As New List(Of InvItem)

        ' create the XmlReaderSettings object
        Dim settings As New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        ' create the XmlReader object
        Dim xmlIn As XmlReader = XmlReader.Create(Path, settings)

        ' read past all nodes to the first Book node
        If xmlIn.ReadToDescendant("Item") Then
            ' create one InvItem object for each Item node
            Do
                Dim item As New InvItem
                xmlIn.ReadStartElement("Item")
                Dim type As String = xmlIn.ReadElementContentAsString
                If type = "Plant" Then
                    item = ReadPlant(xmlIn)
                ElseIf type = "Supply" Then
                    item = ReadSupply(xmlIn)
                End If
                items.Add(item)
            Loop While xmlIn.ReadToNextSibling("Item")
        End If

        ' close the XmlReader object
        xmlIn.Close()

        Return items
    End Function

    Private Shared Function ReadPlant(xmlIn As XmlReader) As Plant
        Dim p As New Plant
        ReadBase(xmlIn, p)
        p.Size = xmlIn.ReadElementContentAsString
        Return p
    End Function

    Private Shared Sub ReadBase(xmlIn As XmlReader, i As InvItem)
        i.ItemNo = xmlIn.ReadElementContentAsInt
        i.Description = xmlIn.ReadElementContentAsString
        i.Price = xmlIn.ReadElementContentAsDecimal
    End Sub

    Private Shared Function ReadSupply(xmlIn As XmlReader) As Supply
        Dim s As New Supply
        ReadBase(xmlIn, s)
        s.Manufacturer = xmlIn.ReadElementContentAsString
        Return s
    End Function

    Public Shared Sub SaveItems(items As List(Of InvItem))
        ' create the XmlWriterSettings object
        Dim settings As New XmlWriterSettings
        settings.Indent = True
        settings.IndentChars = ("    ")

        ' create the XmlWriter object
        Dim xmlOut As XmlWriter = XmlWriter.Create(Path, settings)

        ' write the start of the document
        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("Items")

        ' write each InvItem object to the xml file
        Dim item As InvItem
        For i As Integer = 0 To items.Count - 1
            item = CType(items(i), InvItem)
            If item.GetType.Name = "Plant" Then
                WritePlant(xmlOut, CType(item, Plant))
            ElseIf item.GetType.Name = "Supply" Then
                WriteSupply(xmlOut, CType(item, Supply))
            End If
        Next

        ' write the end tag for the root element
        xmlOut.WriteEndElement()

        ' close the xmlWriter object
        xmlOut.Close()
    End Sub

    Private Shared Sub WritePlant(xmlOut As XmlWriter, p As Plant)
        xmlOut.WriteStartElement("Item")
        xmlOut.WriteElementString("Type", "Plant")
        WriteBase(xmlOut, p)
        xmlOut.WriteElementString("Size", p.Size)
        xmlOut.WriteEndElement()
    End Sub

    Private Shared Sub WriteBase(xmlOut As XmlWriter, i As InvItem)
        xmlOut.WriteElementString("ItemNo", i.ItemNo.ToString)
        xmlOut.WriteElementString("Description", i.Description)
        xmlOut.WriteElementString("Price", i.Price.ToString)
    End Sub

    Private Shared Sub WriteSupply(xmlOut As XmlWriter, s As Supply)
        xmlOut.WriteStartElement("Item")
        xmlOut.WriteElementString("Type", "Supply")
        WriteBase(xmlOut, s)
        xmlOut.WriteElementString("Manufacturer", s.Manufacturer)
        xmlOut.WriteEndElement()
    End Sub
End Class
