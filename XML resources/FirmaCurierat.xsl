<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
    <head>
      <style>
        body {
          font-family: Arial, sans-serif;
        }
        h1, h2 {
          color: #2E8B57;
        }
        table {
          width: 100%;
          border-collapse: collapse;
          margin: 20px 0;
        }
        th, td {
          padding: 8px 12px;
          border: 1px solid #ddd;
          text-align: left;
        }
        th {
          background-color: #4CAF50;
          color: white;
        }
        tr:nth-child(even) {
          background-color: #f2f2f2;
        }
      </style>
    </head>
    <body>
      <h1>Livrari</h1>
      <table>
        <tr>
          <th>ID</th>
          <th>Tip Livrare</th>
          <th>Nume Destinatar</th>
          <th>Telefon</th>
          <th>Email</th>
          <th>Adresa</th>
          <th>Expeditor</th>
          <th>Destinatie</th>
          <th>Data Programata</th>
          <th>Stare Livrare</th>
          <th>Locatie Curenta</th>
          <th>Dimensiuni Colet</th>
          <th>Greutate</th>
          <th>Valoare</th>
          <th>Tip Ambalaj</th>
          <th>Continut</th>
        </tr>
        <xsl:for-each select="livrari/livrare">
          <tr>
            <td><xsl:value-of select="@id"/></td>
            <td><xsl:value-of select="@tip_livrare"/></td>
            <td><xsl:value-of select="destinatar/nume"/></td>
            <td><xsl:value-of select="destinatar/telefon"/></td>
            <td><xsl:value-of select="destinatar/email"/></td>
            <td><xsl:value-of select="destinatar/adresa"/></td>
            <td><xsl:value-of select="expeditor"/></td>
            <td><xsl:value-of select="colet/destinatie"/></td>
            <td><xsl:value-of select="data_programata"/></td>
            <td><xsl:value-of select="stare_livrare"/></td>
            <td><xsl:value-of select="locatie_curenta"/></td>
            <td>
              <xsl:value-of select="colet/dimensiuni/@lungime"/> x
              <xsl:value-of select="colet/dimensiuni/@latime"/> x
              <xsl:value-of select="colet/dimensiuni/@inaltime"/> 
              <xsl:value-of select="colet/dimensiuni/@unitate_masura"/>
            </td>
            <td>
              <xsl:value-of select="colet/greutate"/>
              <xsl:value-of select="colet/greutate/@unitate_masura"/>
            </td>
            <td>
              <xsl:value-of select="colet/valoare"/>
              <xsl:value-of select="colet/valoare/@unitate_masura"/>
            </td>
            <td><xsl:value-of select="colet/ambalaj/@tip"/></td>
            <td><xsl:value-of select="colet/continut"/></td>
          </tr>
        </xsl:for-each>
      </table>
    </body>
  </html>
</xsl:template>

</xsl:stylesheet>