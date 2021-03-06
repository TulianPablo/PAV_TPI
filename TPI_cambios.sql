USE [TPI]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especialidad](
	[id_especialidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[id_especialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidad] ON
INSERT [dbo].[Especialidad] ([id_especialidad], [nombre]) VALUES (1, N'Cardiología',NULL)
INSERT [dbo].[Especialidad] ([id_especialidad], [nombre]) VALUES (2, N'Neurología',NULL)
INSERT [dbo].[Especialidad] ([id_especialidad], [nombre]) VALUES (3, N'Oftalmología',NULL)
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
/****** Object:  Table [dbo].[Perfil]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Perfil] ([id_perfil], [nombre]) VALUES (0, N'Administrador')
INSERT [dbo].[Perfil] ([id_perfil], [nombre]) VALUES (1, N'Encargado')
/****** Object:  Table [dbo].[Localidad]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] NOT NULL,
	[nombre] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1406, N'ACHIRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1407, N'ADELIA MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1408, N'AGUA DE LAS PIEDRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1409, N'AGUA DE ORO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1410, N'AGUA DEL TALA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1411, N'AGUAS DE RAMON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1412, N'AGUILA BLANCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1413, N'ALCIRA ,EST.GIGENA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1414, N'ALEJANDRO ROCA ,EST. ALEJANDRO.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1415, N'ALEJO LEDESMA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1416, N'ALICIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1417, N'ALMAFUERTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1418, N'ALPA CORRAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1419, N'ALTA CORDOBA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1420, N'ALTA CORDOBA ,EST.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1421, N'ALTA GRACIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1422, N'ALTAUTINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1423, N'ALTO ALEGRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1424, N'ALTO DEL TALA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1425, N'ALTO FRESCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1426, N'ALTO SAN PEDRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1427, N'ALTOS DE CHIPION')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1428, N'AMBOY')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1429, N'AMBUL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1430, N'ANA ZUMARAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1431, N'ARBOL BLANCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1432, N'ARGUELLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1433, N'ARIAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1434, N'ARROYITO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1435, N'ARROYO ALGODON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1436, N'ARROYO CABRAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1437, N'ASCOCHINGA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1438, N'ASSUNTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1439, N'ATAHONA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1440, N'ATOS PAMPA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1441, N'AUSONIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1442, N'AVELLANEDA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1443, N'BAJO CHICO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1444, N'BALDE DE LA MORA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1445, N'BALLESTEROS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1446, N'BALLESTEROS SUR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1447, N'BALNEARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1448, N'BAÑADO DE SOTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1449, N'BARRANCA YACO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1450, N'BARRETO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1451, N'BARRIO FLORES ,EMB.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1452, N'BELL VILLE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1453, N'BENGOLEA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1454, N'BENJAMIN GOULD')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1455, N'BERROTARAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1456, N'BIALET MASSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1457, N'BLAS DE ROSALES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1458, N'BOCA DEL TIGRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1459, N'BOUWER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1460, N'BRINKMANN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1461, N'BUCHARDO ,EST.HIPOLITO BOUCHARD')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1462, N'BUEN RETIRO ,AP.EL VADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1463, N'BUENA VISTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1464, N'BUEY MUERTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1465, N'BULNES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1466, N'BURMEISTER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1467, N'CABANA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1468, N'CACHI YACO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1469, N'CACHIYUYO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1470, N'CALCHIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1471, N'CALMAYO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1472, N'CAMILO ALDAO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1473, N'CAMINIAGA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1474, N'CAMPO GRANDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1475, N'CAÑADA DE ALVAREZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1476, N'CAÑADA DE JUME')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1477, N'CAÑADA DE LUQUE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1478, N'CAÑADA DE MACHADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1479, N'CAÑADA DE RIO PINTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1480, N'CAÑADA DE SALAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1481, N'CAÑADA DEL CORO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1482, N'CAÑADA HONDA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1483, N'CANALS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1484, N'CANDELARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1485, N'CANDELARIA NORTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1486, N'CANDELARIA SUD')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1487, N'CANDONGA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1488, N'CANTERAS EL SAUCE ,EST.EMP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1489, N'CANTERAS QUILPO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1490, N'CAPILLA DE LA SAGRADA FAMILIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1491, N'CAPILLA DE LOS REMEDIOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1492, N'CAPILLA DE SITON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1493, N'CAPILLA DEL CARMEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1494, N'CAPILLA DEL MONTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1495, N'CAPITAN GENERAL BERNARDO O HIGGINS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1496, N'CARCANO, RAMON J.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1497, N'CARNERILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1498, N'CAROLINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1499, N'CAROYA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1500, N'CARRILOBO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1501, N'CASA BAMBA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1502, N'CASA GRANDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1503, N'CASERIO LA LONJA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1504, N'CASSAFOUSTH')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1505, N'CASTRO URDIALES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1506, N'CAVALANGO')
GO
print 'Processed 100 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1507, N'CAVANAGH')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1508, N'CAYUQUEO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1509, N'CERRO COLORADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1510, N'CHAJAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1511, N'CHALACEA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1512, N'CHALACEA CENTRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1513, N'CHAMICO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1514, N'CHAÑAR VIEJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1515, N'CHAÑARITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1516, N'CHANCANI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1517, N'CHARBONIER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1518, N'CHARRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1519, N'CHAZON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1520, N'CHILIBROSTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1521, N'CHUCHIRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1522, N'CHUCUL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1523, N'CHUÑA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1524, N'CHUÑA HUASI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1525, N'CHURQUI CAÑADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1526, N'CIENAGA DE ALLENDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1527, N'CIENAGA DE BRITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1528, N'CIENAGA DEL CORO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1529, N'CINTRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1530, N'COLAZO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1531, N'COLONIA 10 DE JULIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1532, N'COLONIA ALMADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1533, N'COLONIA ALMADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1534, N'COLONIA ANITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1535, N'COLONIA ANITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1536, N'COLONIA BISMARCK')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1537, N'COLONIA BREMEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1538, N'COLONIA CAROYA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1539, N'COLONIA COYUNDA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1540, N'COLONIA EL CARMEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1541, N'COLONIA LA TORDILLA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1542, N'COLONIA LAS CUATRO ESQUINAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1543, N'COLONIA MACKINLAY')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1544, N'COLONIA MALBERTINA ,EMB.KILOMETRO 531')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1545, N'COLONIA MARINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1546, N'COLONIA PROSPERIDAD')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1547, N'COLONIA RIO CHICO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1548, N'COLONIA SAN BARTOLOME')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1549, N'COLONIA SAN PEDRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1550, N'COLONIA SAN RAFAEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1551, N'COLONIA SANTA MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1552, N'COLONIA SANTA MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1553, N'COLONIA TIROLESA ,EST.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1554, N'COLONIA VEINTICINCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1555, N'COLONIA VIDELA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1556, N'COLONIA VIGNAUD')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1557, N'COLONIA WALTELINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1558, N'CONLARA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1559, N'COPACABANA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1560, N'CORDOBA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1561, N'CORONEL BAIGORRIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1562, N'CORONEL MOLDES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1563, N'CORONEL OLMEDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1564, N'CORRAL DE BARRANCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1565, N'CORRAL DE BUSTOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1566, N'CORRAL DEL BAJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1567, N'CORRALITO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1568, N'CORTES, JERONIMO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1569, N'COSME')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1570, N'COSQUIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1571, N'COSTA SACATE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1572, N'COTAGAITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1573, N'CRAIK, JAMES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1574, N'CRUZ ALTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1575, N'CRUZ CHICA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1576, N'CRUZ DE CAÑA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1577, N'CRUZ DEL EJE ,EST.NORTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1578, N'CRUZ DEL QUEMADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1579, N'CRUZ GRANDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1580, N'CRUZ MOJADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1581, N'CUATRO CAMINOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1582, N'CUATRO VIENTOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1583, N'CUCHI CORRAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1584, N'CUEVA DE INDIOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1585, N'CUEVA DE LOS PAJARITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1586, N'CURAPALIGUE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1587, N'DE LA QUINTANA, JOSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1588, N'DE LA SERNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1589, N'DEAN FUNES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1590, N'DEL CAMPILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1591, N'DESPEÑADEROS ,EST.DR.LUCAS A.DE OLMOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1592, N'DEVOTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1593, N'DIQUE SAN ROQUE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1594, N'DOCTOR NICASIO SALAS OROÑO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1595, N'DOLORES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1596, N'DUMESNIL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1597, N'EL ARAÑADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1598, N'EL BAÑADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1599, N'EL BAÑADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1600, N'EL BRETE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1601, N'EL CADILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1602, N'EL CANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1603, N'EL CHACHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1604, N'EL CRISPIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1605, N'EL DIQUECITO ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1606, N'EL DURAZNO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1607, N'EL DURAZNO')
GO
print 'Processed 200 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1608, N'EL FARO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1609, N'EL FLORENTINO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1610, N'EL FORTIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1611, N'EL FUERTECITO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1612, N'EL GATEADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1613, N'EL MANZANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1614, N'EL MIRADOR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1615, N'EL PAMPERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1616, N'EL PAYADOR ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1617, N'EL PERCHEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1618, N'EL PERCHEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1619, N'EL PONIENTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1620, N'EL PORTEZUELO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1621, N'EL QUEBRACHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1622, N'EL QUEBRACHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1623, N'EL RASTREADOR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1624, N'EL RETIRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1625, N'EL ROSARIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1626, N'EL SAUCE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1627, N'EL SUNCHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1628, N'EL TAMBO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1629, N'EL TIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1630, N'EL TOSTADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1631, N'EL TUSCAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1632, N'EL VENCE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1633, N'EL ZAINO ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1634, N'EL ZAPATO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1635, N'ELCANO, SEBASTIAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1636, N'ELENA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1637, N'EMBALSE MINISTRO JUAN PISTARINI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1638, N'ENCRUCIJADAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1639, N'ESCALANTE, WENCESLAO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1640, N'ESCUELA PARACAIDISTAS ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1641, N'ESPINILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1642, N'ESQUINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1643, N'ESTANCIA DE GUADALUPE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1644, N'ETRURIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1645, N'FALDA DEL CARMEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1646, N'FERREYRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1647, N'FLORA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1648, N'FRAGUEIRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1649, N'FRAY CAYETANO RODRIGUEZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1650, N'FREYRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1651, N'FUNES, DOMINGO ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1652, N'FUNES, PEDRO E.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1653, N'GARCIA, RAFAEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1654, N'GAVILAN ,EST.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1655, N'GENERAL BALDISSERA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1656, N'GENERAL CABRERA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1657, N'GENERAL DEHEZA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1658, N'GENERAL FOTHERINGHAM')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1659, N'GENERAL LEVALLE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1660, N'GENERAL ORTIZ DE OCAMPO ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1661, N'GENERAL PAZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1662, N'GENERAL ROCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1663, N'GENERAL SOLER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1664, N'GIGENA ESTACION')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1665, N'GOULD, BENJAMIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1666, N'GUANACO MUERTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1667, N'GUARDIA VIEJA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1668, N'GUASAPAMPA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1669, N'GUATIMOZIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1670, N'GUIÑAZU')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1671, N'GUTEMBERG')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1672, N'HERNANDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1673, N'HUANCHILLA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1674, N'HUASCHA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1675, N'HUERTA GRANDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1676, N'HUINCA RENANCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1677, N'IDIAZABAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1678, N'IGLESIA VIEJA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1679, N'IMPIRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1680, N'INGENIERO MALMEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1681, N'INRIVILLE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1682, N'ISCHILIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1683, N'ISCHILIN VIEJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1684, N'ISLA DE SAN ANTONIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1685, N'ISLA VERDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1686, N'ITALO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1687, N'JEANMAIRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1688, N'JESUS MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1689, N'JUAREZ CELMAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1690, N'JUAREZ, MARCOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1691, N'KILOMETRO 1,5 AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1692, N'KILOMETRO 136 ,EMP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1693, N'KILOMETRO 16')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1694, N'KILOMETRO 16')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1695, N'KILOMETRO 182 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1696, N'KILOMETRO 23')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1697, N'KILOMETRO 23')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1698, N'KILOMETRO 25')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1699, N'KILOMETRO 271 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1700, N'KILOMETRO 316 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1701, N'KILOMETRO 394 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1702, N'KILOMETRO 466 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1703, N'KILOMETRO 480 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1704, N'KILOMETRO 541 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1705, N'KILOMETRO 563 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1706, N'KILOMETRO 57 ,EST.EMB.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1707, N'KILOMETRO 579 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1708, N'KILOMETRO 581 ,EMB.')
GO
print 'Processed 300 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1709, N'KILOMETRO 608 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1710, N'KILOMETRO 618 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1711, N'KILOMETRO 636 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1712, N'KILOMETRO 651 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1713, N'KILOMETRO 679')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1714, N'KILOMETRO 691 ,DV.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1715, N'KILOMETRO 7')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1716, N'KILOMETRO 730 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1717, N'KILOMETRO 745')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1718, N'KILOMETRO 859 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1719, N'KILOMETRO 865 ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1720, N'KILOMETRO 881 ,EMB.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1721, N'KILOMETRO 9')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1722, N'KILOMETRO 907 ,EST.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1723, N'KILOMETRO 931')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1724, N'LA AGUADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1725, N'LA ARGENTINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1726, N'LA BISMUTINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1727, N'LA BUENA PARADA ,EST.COMECHINGONES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1728, N'LA CALERA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1729, N'LA CAÑADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1730, N'LA CAÑADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1731, N'LA CARLOTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1732, N'LA CAUTIVA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1733, N'LA CORTADERA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1734, N'LA CRUZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1735, N'LA CUESTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1736, N'LA CUMBRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1737, N'LA ESPERANZA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1738, N'LA ESQUINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1739, N'LA ESTANCIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1740, N'LA FALDA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1741, N'LA FRANCIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1742, N'LA GILDA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1743, N'LA GRANJA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1744, N'LA HERRADURA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1745, N'LA HIGUERA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1746, N'LA JUANITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1747, N'LA LAGUNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1748, N'LA MAJADILLA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1749, N'LA MUDANA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1750, N'LA NACIONAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1751, N'LA PALESTINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1752, N'LA PAMPA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1753, N'LA PAQUITA ,EST.PRESIDENTE F.ALCORTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1754, N'LA PARA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1755, N'LA PATRIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1756, N'LA PAZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1757, N'LA PENCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1758, N'LA PLAYA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1759, N'LA PLAYOSA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1760, N'LA POBLACION')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1761, N'LA POSTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1762, N'LA PUERTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1763, N'LA PUERTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1764, N'LA RAMADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1765, N'LA REPRESA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1766, N'LA RINCONADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1767, N'LA SERRANITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1768, N'LA TABLADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1769, N'LA TABLADA ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1770, N'LA TIGRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1771, N'LA TOMA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1772, N'LA TOMA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1773, N'LABORDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1774, N'LABOULAYE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1775, N'LAGUNA DEL MONTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1776, N'LAGUNA DEL SUNCHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1777, N'LAGUNA LARGA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1778, N'LAGUNA OSCURA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1779, N'LAGUNILLA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1780, N'LARSEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1781, N'LAS ACEQUIAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1782, N'LAS ARRIAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1783, N'LAS AVERIAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1784, N'LAS BAJADAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1785, N'LAS CALLES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1786, N'LAS CAÑITAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1787, N'LAS CHACRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1788, N'LAS CHACRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1789, N'LAS CHACRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1790, N'LAS CHACRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1791, N'LAS ENSENADAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1792, N'LAS GAMAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1793, N'LAS HIGUERAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1794, N'LAS ISLETILLAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1795, N'LAS JUNTURAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1796, N'LAS MOJARRAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1797, N'LAS MOSTAZAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1798, N'LAS MOSTAZAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1799, N'LAS PALMAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1800, N'LAS PEÑAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1801, N'LAS PEÑAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1802, N'LAS PERDICES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1803, N'LAS RABONAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1804, N'LAS SALADAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1805, N'LAS TAPIAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1806, N'LAS TAPIAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1807, N'LAS TOSCAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1808, N'LAS TOSCAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1809, N'LAS VARAS')
GO
print 'Processed 400 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1810, N'LAS VARILLAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1811, N'LAS VERTIENTES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1812, N'LASPIUR, SATURNINO M.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1813, N'LECUEDER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1814, N'LEDESMA, ALEJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1815, N'LEGUIZAMON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1816, N'LEONES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1817, N'LOA ALAMOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1818, N'LOA ALGARROBOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1819, N'LOMAS DE SAN JOSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1820, N'LOS ALFALFARES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1821, N'LOS ALTOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1822, N'LOS CADILLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1823, N'LOS CALLEJONES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1824, N'LOS CERRILLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1825, N'LOS CERRILLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1826, N'LOS CHAÑARES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1827, N'LOS CHAÑARITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1828, N'LOS CISNES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1829, N'LOS COCOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1830, N'LOS COMETIERRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1831, N'LOS CONDORES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1832, N'LOS GIGANTES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1833, N'LOS HORNILLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1834, N'LOS HOYOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1835, N'LOS JAGUELES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1836, N'LOS MANANTIALES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1837, N'LOS MEDANITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1838, N'LOS MISTOLES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1839, N'LOS MOLINOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1840, N'LOS MOLLES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1841, N'LOS MOLLES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1842, N'LOS MORTERITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1843, N'LOS PORONGOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1844, N'LOS POZOS ,AP.KILOMETRO 827')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1845, N'LOS QUEBRACHITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1846, N'LOS QUEBRACHITOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1847, N'LOS REARTES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1848, N'LOS SAUCES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1849, N'LOS SURGENTES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1850, N'LOS TARTAROS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1851, N'LOS ZORROS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1852, N'LOZADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1853, N'LUCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1854, N'LUGONES, LEOPOLDO ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1855, N'LUQUE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1856, N'LUTTI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1857, N'LUXARDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1858, N'LUYABA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1859, N'MACHA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1860, N'MAGIGASTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1861, N'MAJADA DE SANTIAGO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1862, N'MALAGUENO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1863, N'MALENA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1864, N'MALLIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1865, N'MALVINAS ARGENTINAS ,EST.KILOMETRO 711')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1866, N'MANANTIALES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1867, N'MANFREDI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1868, N'MANSILLA, LUCIO V.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1869, N'MAQUINISTA GALLINI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1870, N'MARULL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1871, N'MATORRALES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1872, N'MATTALDI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1873, N'MEDIA LUNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1874, N'MEDIA NARANJA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1875, N'MELO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1876, N'MENDIOLAZA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1877, N'MINA CLAVERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1878, N'MIRAMAR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1879, N'MOLINARI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1880, N'MONTE BUEY')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1881, N'MONTE CRISTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1882, N'MONTE DE LOS GAUCHOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1883, N'MONTE DEL ROSARIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1884, N'MONTE LEÑA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1885, N'MONTE MAIZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1886, N'MONTE RALO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1887, N'MONTE REDONDO ,EST.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1888, N'MORRISON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1889, N'MORTEROS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1890, N'MULA MUERTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1891, N'MUSSI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1892, N'NARVAJA, TRISTAN ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1893, N'NAZCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1894, N'NINALQUIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1895, N'NOETINGER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1896, N'NONO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1897, N'NUEVA ALDALUCIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1898, N'NUÑEZ DEL ORADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1899, N'OBISPO TREJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1900, N'OJO DE AGUA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1901, N'OJO DE AGUA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1902, N'OLAEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1903, N'OLAETA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1904, N'OLIVA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1905, N'OLMOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1906, N'ONAGOITY')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1907, N'ONCATIVO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1908, N'ONGAMIRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1909, N'ORDOÑEZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1910, N'ORO GRUESO')
GO
print 'Processed 500 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1911, N'PACHANGO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1912, N'PACHECO DE MELO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1913, N'PAJAS BLANCAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1914, N'PAMPAYASTA NORTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1915, N'PAMPAYASTA SUR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1916, N'PAN DE AZUCAR ,AP.KILOMETRO 592')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1917, N'PANAHOLMA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1918, N'PASCANAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1919, N'PASCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1920, N'PASO DEL RIO SECO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1921, N'PASO VIEJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1922, N'PAUNERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1923, N'PAVIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1924, N'PEGASANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1925, N'PELLICO, SILVIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1926, N'PETER, JAIME')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1927, N'PICHANAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1928, N'PIEDRA BLANCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1929, N'PIEDRAS ANCHAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1930, N'PIEDRAS BLANCAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1931, N'PIEDRITA BLANCA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1932, N'PIEDRITAS ROSADAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1933, N'PILAR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1934, N'PINAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1935, N'PINCEN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1936, N'PINTOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1937, N'PIQUILLIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1938, N'PIZARRO, MODESTINO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1939, N'PLAYA GRANDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1940, N'PLAZA BRUNO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1941, N'PLAZA COLAZO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1942, N'PLAZA DE MERCEDES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1943, N'PLAZA DEHEZA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1944, N'PLAZA LUXARDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1945, N'PLAZA SAN FRANCISCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1946, N'PLAZA VIDELA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1947, N'POCHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1948, N'PORTEÑA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1949, N'POSSE, JUSTINIANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1950, N'POZO DE LA LOMA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1951, N'POZO DE LA PAMPA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1952, N'POZO DE LAS OLLAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1953, N'POZO DEL CHAÑAR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1954, N'POZO DEL MOLLE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1955, N'POZO DEL MORO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1956, N'POZO DEL TIGRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1957, N'PRETOT FREYRE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1958, N'PUEBLO ITALIANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1959, N'PUEBLO VIEJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1960, N'PUERTA COLORADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1961, N'PUESTO DE AFUERA ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1962, N'PUESTO DE CASTRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1963, N'PUESTO DEL ROSARIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1964, N'PUESTO PUCHETA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1965, N'PUESTO SAN JOSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1966, N'PUNILLA ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1967, N'PUNTA DEL AGUA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1968, N'PUNTA DEL AGUA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1969, N'PUNTA DEL AGUA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1970, N'QUEBRACHO HERRADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1971, N'QUEBRADA DE LOS POZOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1972, N'QUILINO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1973, N'QUISQUIZACATE ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1974, N'RANGEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1975, N'RANQUELES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1976, N'RARA FORTUNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1977, N'RAYO CORTADO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1978, N'RINCON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1979, N'RINCON DE LUNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1980, N'RIO BAMBA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1981, N'RIO CEBALLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1982, N'RIO CUARTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1983, N'RIO CUARTO NORTE ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1984, N'RIO DE LOS MOLINOS ,PDA.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1985, N'RIO DE LOS SAUCES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1986, N'RIO HONDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1987, N'RIO PRIMERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1988, N'RIO SEGUNDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1989, N'RIO TERCERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1990, N'RIVERA INDARTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1991, N'ROCA, ALEJANDRO ,EST.ALEJANDRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1992, N'RODEO GRANDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1993, N'RODEO VIEJO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1994, N'RODRIGUEZ DEL BUSTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1995, N'ROJAS, DIEGO DE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1996, N'ROSALES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1997, N'ROSALES, BLAS DE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1998, N'RUIZ DIAZ DE GUZMAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (1999, N'RUMIYACO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2000, N'SACANTA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2001, N'SAGUION')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2002, N'SAIRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2003, N'SALADILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2004, N'SALAS, MIGUEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2005, N'SALDAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2006, N'SALGUERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2007, N'SALSACATE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2008, N'SALSIPUEDES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2009, N'SAMPACHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2010, N'SAN AGUSTIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2011, N'SAN AGUSTIN')
GO
print 'Processed 600 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2012, N'SAN AMBROSIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2013, N'SAN ANTINIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2014, N'SAN ANTONIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2015, N'SAN ANTONIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2016, N'SAN ANTONIO DE ARREDONDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2017, N'SAN ANTONIO DE LITIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2018, N'SAN BARTOLOME')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2019, N'SAN BASILIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2020, N'SAN BUENAVENTURA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2021, N'SAN BUENAVENTURA ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2022, N'SAN CARLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2023, N'SAN CARLOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2024, N'SAN CLEMENTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2025, N'SAN ESTEBAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2026, N'SAN FERNANDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2027, N'SAN FRANCISCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2028, N'SAN FRANCISCO DEL CHAÑAR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2029, N'SAN GERONIMO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2030, N'SAN IGNACIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2031, N'SAN IGNACIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2032, N'SAN JAVIER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2033, N'SAN JOAQUIN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2034, N'SAN JOSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2035, N'SAN JOSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2036, N'SAN JOSE DE LA DORMIDA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2037, N'SAN JOSE DE LAS SALINAS ,EST.SAN JOSE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2038, N'SAN JOSE DEL SALTEÑO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2039, N'SAN LORENZO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2040, N'SAN LUIS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2041, N'SAN MARCOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2042, N'SAN MARCOS SIERRA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2043, N'SAN MIGUEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2044, N'SAN PEDRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2045, N'SAN PEDRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2046, N'SAN PEDRO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2047, N'SAN PEDRO DE TOYOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2048, N'SAN PEDRO NORTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2049, N'SAN RAFAEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2050, N'SAN ROQUE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2051, N'SAN SEVERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2052, N'SAN VICENTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2053, N'SANABRIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2054, N'SANTA ANA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2055, N'SANTA CATALINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2056, N'SANTA CATALINA ,EST.HOLMBERG')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2057, N'SANTA CRUZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2058, N'SANTA EUFEMIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2059, N'SANTA ISABEL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2060, N'SANTA MAGDALENA ,EST.JOVITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2061, N'SANTA MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2062, N'SANTA MARIA DE PUNILLA ,EST.SANTA MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2063, N'SANTA ROSA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2064, N'SANTA ROSA DE CALAMUCHITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2065, N'SANTA ROSA DE RIO PRIMERO ,EST.V.S.ROSA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2066, N'SANTA SABINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2067, N'SANTA TERESA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2068, N'SANTA VICTORIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2069, N'SARMIENTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2070, N'SAUCE DE LOS QUEVEDOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2071, N'SEEBER')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2072, N'SERRANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2073, N'SERREZUELA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2074, N'SIMBOLAR')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2075, N'SINSACATE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2076, N'SOCONCHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2077, N'SOTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2078, N'SUCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2079, N'SUQUIA ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2080, N'SVILLA NUEVA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2081, N'TABAQUILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2082, N'TALA CAÑADA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2083, N'TALA CRUZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2084, N'TALA NORTE ,EST.EL ALCALDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2085, N'TALAINI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2086, N'TANCACHA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2087, N'TANTI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2088, N'TANTI NUEVO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2089, N'TASMA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2090, N'TEGUA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2091, N'TEMPLE, SANTIAGO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2092, N'THEA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2093, N'TICINO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2094, N'TILQUICHO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2095, N'TINOCO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2096, N'TIO PUJIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2097, N'TOLEDO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2098, N'TOSNO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2099, N'TOSQUITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2100, N'TOTORALEJOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2101, N'TRANSITO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2102, N'TRAVESIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2103, N'TRES ARBOLES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2104, N'TRINCHERA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2105, N'TUCLAME')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2106, N'UCACHA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2107, N'UNQUILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2108, N'VALLE HERMOSO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2109, N'VELEZ SARSFIELD, DALMACIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2110, N'VELEZ SARSFIELD, DALMACIO ,AP.')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2111, N'VIAMONTE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2112, N'VICUÑA MACKENNA')
GO
print 'Processed 700 total records'
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2113, N'VILLA AIZACATE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2114, N'VILLA ALICIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2115, N'VILLA ALLENDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2116, N'VILLA ASCASUBI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2117, N'VILLA BUSTOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2118, N'VILLA CANDELARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2119, N'VILLA CARLOS PAZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2120, N'VILLA CERRO AZUL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2121, N'VILLA COLANCHANGA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2122, N'VILLA COLONIA ITALIANA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2123, N'VILLA CONCEPCION DEL TIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2124, N'VILLA CORAZON DE MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2125, N'VILLA CURA BROCHERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2126, N'VILLA DE LAS ROSAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2127, N'VILLA DE MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2128, N'VILLA DE SOTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2129, N'VILLA DEL DIQUE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2130, N'VILLA DEL LAGO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2131, N'VILLA DEL ROSARIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2132, N'VILLA DEL TOTORAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2133, N'VILLA DEL TRANSITO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2134, N'VILLA DOLORES')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2135, N'VILLA ELISA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2136, N'VILLA ESQUIU')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2137, N'VILLA FONTANA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2138, N'VILLA GARCIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2139, N'VILLA GENERAL BELGRANO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2140, N'VILLA GIARDINO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2141, N'VILLA GUTIERREZ ,EMB. KM. 807')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2142, N'VILLA HUIDOBRO ,EST.CAÑADA VERDE')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2143, N'VILLA ICHO CRUZ')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2144, N'VILLA INDEPENDENCIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2145, N'VILLA LOS MOLINOS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2146, N'VILLA MARIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2147, N'VILLA MODERNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2148, N'VILLA ÑU PORA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2149, N'VILLA QUILINO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2150, N'VILLA RAFAEL BENEGAS')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2151, N'VILLA REDUCCION')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2152, N'VILLA ROSARIO DEL SALADILLO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2153, N'VILLA ROSSI')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2154, N'VILLA RUMIPAL')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2155, N'VILLA SAN ANTONIO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2156, N'VILLA SAN ESTEBAN')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2157, N'VILLA SARMIENTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2158, N'VILLA TULUMBA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2159, N'VILLA VALERIA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2160, N'VILLA VAUDAGNA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2161, N'VILLA VISO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2162, N'VIVAS, PEDRO E. ,EMB.KILOMETRO 658')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2163, N'VIVERO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2164, N'WASHINGTON')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2165, N'WATT ,EST.MELIDEO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2166, N'YACANTO')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2167, N'YACANTO DE CALAMUCHITA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2168, N'YOCSINA')
INSERT [dbo].[Localidad] ([id_localidad], [nombre]) VALUES (2169, N'ZUMARAN, ANA')
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[id_tipoDoc] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TipoDoc] PRIMARY KEY CLUSTERED 
(
	[id_tipoDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TipoDoc] ([id_tipoDoc], [nombre]) VALUES (0, N'DNI')
INSERT [dbo].[TipoDoc] ([id_tipoDoc], [nombre]) VALUES (1, N'LE')
INSERT [dbo].[TipoDoc] ([id_tipoDoc], [nombre]) VALUES (2, N'LC')
/****** Object:  Table [dbo].[TipoAfiliado]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoAfiliado](
	[id_tipoAfiliado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_TipoAfiliado] PRIMARY KEY CLUSTERED 
(
	[id_tipoAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TipoAfiliado] ON
INSERT [dbo].[TipoAfiliado] ([id_tipoAfiliado], [nombre]) VALUES (1, N'Titular', NULL)
INSERT [dbo].[TipoAfiliado] ([id_tipoAfiliado], [nombre]) VALUES (2, N'Adherentes', NULL)
INSERT [dbo].[TipoAfiliado] ([id_tipoAfiliado], [nombre]) VALUES (3, N'Convenio con organismos', NULL)
SET IDENTITY_INSERT [dbo].[TipoAfiliado] OFF
/****** Object:  Table [dbo].[PrestacionAdicional]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PrestacionAdicional](
	[cod_prestacion] [int] NOT NULL,
	[descripcion] [varchar](30) NOT NULL,
	[costo] [float] NOT NULL,
 CONSTRAINT [PK_PrestacionAdicional] PRIMARY KEY CLUSTERED 
(
	[cod_prestacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PracticaXTipoAfiliado]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PracticaXTipoAfiliado](
	[id_tipoPractica] [int] NOT NULL,
	[id_tipoAfiliado] [int] NOT NULL,
	[precioPractica] [int] NOT NULL,
	[porc_cobertura] [int] NOT NULL,
 CONSTRAINT [PK_PracticaXTipoAfiliado] PRIMARY KEY CLUSTERED 
(
	[id_tipoPractica] ASC,
	[id_tipoAfiliado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (1, 1, 300, 50)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (1, 2, 300, 30)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (1, 3, 300, 25)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (2, 1, 250, 100)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (2, 2, 250, 80)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (2, 3, 250, 60)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (3, 1, 500, 70)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (3, 2, 500, 45)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (3, 3, 500, 30)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (4, 1, 800, 50)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (4, 2, 800, 35)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (4, 3, 800, 30)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (5, 1, 600, 20)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (5, 2, 600, 10)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (5, 3, 600, 5)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (11, 1, 1000, 70)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (11, 2, 1000, 60)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (11, 3, 1000, 50)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (12, 1, 400, 30)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (12, 2, 400, 50)
INSERT [dbo].[PracticaXTipoAfiliado] ([id_tipoPractica], [id_tipoAfiliado], [precioPractica], [porc_cobertura]) VALUES (12, 3, 400, 35)
/****** Object:  Table [dbo].[Cuota]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuota](
	[año] [date] NOT NULL,
	[mes] [date] NOT NULL,
	[importe] [float] NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
 CONSTRAINT [PK_Cuota] PRIMARY KEY CLUSTERED 
(
	[año] ASC,
	[mes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[id_barrio] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[id_localidad] [int] NOT NULL,
 CONSTRAINT [PK_Barrio] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (1, N'Alberdi', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (2, N'Alejandro Centeno', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (3, N'Alta Córdoba', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (4, N'Alto Alberdi', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (5, N'Alto Palermo', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (6, N'Argüello', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (7, N'	Bialet Masse', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (8, N'	Centro', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (9, N'Centro América', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (10, N'Cerro de las Rosas', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (11, N'General Mosconi', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (12, N'Granja De Funes', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (13, N'Guiñazu', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (14, N'Juan B Justo', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (15, N'Liceo General Paz', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (16, N'Los Boulevares', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (17, N'	Los Paraísos', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (18, N'Marques Anexo', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (19, N'Nueva Córdoba', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (20, N'	Santa Cecilia', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (21, N'	Urca', 1560)
INSERT [dbo].[Barrio] ([id_barrio], [nombre], [id_localidad]) VALUES (22, N'Villa Cabrera', 1560)
/****** Object:  Table [dbo].[Afiliado]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Afiliado](
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[id_tipoDoc] [int] NOT NULL,
	[nro_doc] [int] NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[calle] [nvarchar](50) NOT NULL,
	[nro] [int] NOT NULL,
	[id_barrio] [int] NOT NULL,
	[telefono] [int] NOT NULL,
	[id_tipoAfiliado] [int] NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_Afiliado] PRIMARY KEY CLUSTERED 
(
	[id_tipoDoc] ASC,
	[nro_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Afiliado] ([nombre], [apellido], [id_tipoDoc], [nro_doc], [fecha_nac], [calle], [nro], [id_barrio], [telefono], [id_tipoAfiliado], [fecha_alta], [fecha_baja]) VALUES (N'Emanuel', N'Gomez', 1, 99999999, CAST(0x1C190B00 AS Date), N'av. Alem ', 2323, 3, 4778765, 1, CAST(0xFD3B0B00 AS Date), NULL)
/****** Object:  Table [dbo].[CostosXTipoAfiliado]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CostosXTipoAfiliado](
	[id_tipoAfiliado] [int] NOT NULL,
	[edadDesde] [int] NOT NULL,
	[edadHasta] [int] NOT NULL,
	[costoAfiliacion] [float] NOT NULL,
	[importeCuota] [float] NOT NULL,
 CONSTRAINT [PK_CostosXTipoAfiliado] PRIMARY KEY CLUSTERED 
(
	[id_tipoAfiliado] ASC,
	[edadDesde] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Practica]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Practica](
	[id_practica] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_Practica] PRIMARY KEY CLUSTERED 
(
	[id_practica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Practica] ON
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (1, N'ELECTROCARDIOGRAMA ', 1, NULL)
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (2, N'CARDIOVERSION.', 1, NULL)
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (3, N'MAPEO CEREBRAL COMPUTARIZADO', 2, NULL)
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (4, N'ELECTROENCEFALOGRAFIA CON ACTIVACION SIMPLE.', 2, NULL)
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (5, N'ELECTRODIAGNOSTICO.', 2, NULL)
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (11, N'FONDO DE OJO Y/O ESQUIASCOPIA ', 3, NULL)
INSERT [dbo].[Practica] ([id_practica], [nombre], [id_especialidad], [fecha_baja]) VALUES (12, N'GONIOSCOPIA.-UNI O BILATERAL-', 3, NULL)
SET IDENTITY_INSERT [dbo].[Practica] OFF
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuario] [varchar](30) NOT NULL,
	[password] [nvarchar](10) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](40) NOT NULL,
	[fecha_Nac] [date] NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[fecha_baja] [date] NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Usuario] ([usuario], [password], [nombre], [apellido], [fecha_Nac], [mail], [fecha_alta], [fecha_baja], [id_perfil]) VALUES (N'adm', N'adm123', N'German', N'Carrizo', CAST(0x09160B00 AS Date), N'german@gmail.com', CAST(0x013C0B00 AS Date), NULL, 0)
INSERT [dbo].[Usuario] ([usuario], [password], [nombre], [apellido], [fecha_Nac], [mail], [fecha_alta], [fecha_baja], [id_perfil]) VALUES (N'enc', N'enc123', N'Matias', N'Rodriguez', CAST(0xC2190B00 AS Date), N'matias@gmail.com', CAST(0xFD3B0B00 AS Date), NULL, 1)
/****** Object:  Table [dbo].[Profesional]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesional](
	[matricula] [int] NOT NULL,
	[apellido] [nvarchar](30) NOT NULL,
	[nombre] [nvarchar](40) NOT NULL,
	[id_tipoDoc] [int] NOT NULL,
	[nro_doc] [int] NOT NULL,
	[fecha_nac] [datetime] NOT NULL,
	[calle] [nvarchar](50) NOT NULL,
	[nro] [int] NOT NULL,
	[id_barrio] [int] NOT NULL,
	[telefono] [int] NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_Profesional] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Profesional] ([matricula], [apellido], [nombre], [id_tipoDoc], [nro_doc], [fecha_nac], [calle], [nro], [id_barrio], [telefono], [fecha_baja]) VALUES (2222, N'Marquez', N'Rodrigo', 0, 34545999, CAST(0x0000809200000000 AS DateTime), N'los alemanes', 3400, 16, 4778782, NULL)
/****** Object:  Table [dbo].[GrupoAfiliado]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoAfiliado](
	[id_tipoDocTitular] [int] NOT NULL,
	[nro_docTitular] [int] NOT NULL,
	[id_tipoDocFamiliar] [int] NOT NULL,
	[nro_docFamiliar] [int] NOT NULL,
 CONSTRAINT [PK_GrupoAfiliado] PRIMARY KEY CLUSTERED 
(
	[id_tipoDocTitular] ASC,
	[nro_docTitular] ASC,
	[id_tipoDocFamiliar] ASC,
	[nro_docFamiliar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CobroCuotas]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CobroCuotas](
	[año] [date] NOT NULL,
	[mes] [date] NOT NULL,
	[id_tipoDocAfiliado] [int] NOT NULL,
	[nroDocAfiliado] [int] NOT NULL,
	[fecha_cobro] [date] NOT NULL,
	[importe] [float] NOT NULL,
 CONSTRAINT [PK_CobroCuotas] PRIMARY KEY CLUSTERED 
(
	[año] ASC,
	[mes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CentroMedico]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CentroMedico](
	[nro_centroMedico] [int] NOT NULL,
	[denominacion] [nvarchar](50) NOT NULL,
	[calle] [nvarchar](40) NOT NULL,
	[numero] [int] NOT NULL,
	[id_barrio] [int] NOT NULL,
	[telefono] [int] NOT NULL,
	[mail] [nvarchar](30) NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_CentroMedico] PRIMARY KEY CLUSTERED 
(
	[nro_centroMedico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CentroMedico] ([nro_centroMedico], [denominacion], [calle], [numero], [id_barrio], [telefono], [mail], [fecha_baja]) VALUES (1, N'Medical Center', N'9 de julio', 3200, 8, 4770934, N'medicalCenter@gmail.com', NULL)
INSERT [dbo].[CentroMedico] ([nro_centroMedico], [denominacion], [calle], [numero], [id_barrio], [telefono], [mail], [fecha_baja]) VALUES (2, N'del sol ', N'ituzaingo', 3000, 8, 4771231, N'delsol@hotmail.com', CAST(0x043C0B00 AS Date))
/****** Object:  Table [dbo].[Afiliacion]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Afiliacion](
	[nroAfiliacion] [int] NOT NULL,
	[fechaAfiliacion] [datetime] NOT NULL,
	[id_tipoDocAfiliado] [int] NOT NULL,
	[nro_docAfiliado] [int] NOT NULL,
	[cod_prestacionAdicional] [int] NOT NULL,
	[costoAfiliacion] [float] NOT NULL,
	[anulada] [bit] NULL,
	[fechaBaja] [datetime] NULL,
 CONSTRAINT [PK_Afiliacion] PRIMARY KEY CLUSTERED 
(
	[nroAfiliacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AtencionMedica]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AtencionMedica](
	[fecha_atencion] [datetime] NOT NULL,
	[nro_atencion] [int] NOT NULL,
	[id_tipoDocAfiliado] [int] NOT NULL,
	[nro_docAfiliado] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[nro_centroMedico] [int] NOT NULL,
	[matricula] [int] NOT NULL,
	[fecha_baja] [date] NULL,
 CONSTRAINT [PK_AtencionMedica] PRIMARY KEY CLUSTERED 
(
	[nro_atencion] ASC,
	[nro_centroMedico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AtencionMedica] ([fecha_atencion], [nro_atencion], [id_tipoDocAfiliado], [nro_docAfiliado], [id_especialidad], [nro_centroMedico], [matricula], [fecha_baja]) VALUES (CAST(0x0000A6A900000000 AS DateTime), 1, 1, 99999999, 2, 1, 2222, NULL)
/****** Object:  Table [dbo].[ProfesionalXEspecialidadXCentroMedico]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico](
	[matricula] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
	[nro_centroMedico] [int] NOT NULL,
 CONSTRAINT [PK_ProfesionalXEspecialidadXCentroMedico] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC,
	[id_especialidad] ASC,
	[nro_centroMedico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[nro_facturacion] [int] NOT NULL,
	[fecha_facturacion] [date] NOT NULL,
	[nro_centroMedico] [int] NOT NULL,
 CONSTRAINT [PK_Facturacion] PRIMARY KEY CLUSTERED 
(
	[nro_facturacion] ASC,
	[nro_centroMedico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFacturacion]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFacturacion](
	[nro_facturacion] [int] NOT NULL,
	[nro_centroMedico] [int] NOT NULL,
	[id_practica] [int] NOT NULL,
	[subtotal_cubierto] [float] NOT NULL,
 CONSTRAINT [PK_DetalleFacturacion] PRIMARY KEY CLUSTERED 
(
	[nro_facturacion] ASC,
	[nro_centroMedico] ASC,
	[id_practica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleAtencionMedica]    Script Date: 10/24/2016 20:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleAtencionMedica](
	[fecha_atencion] [datetime] NOT NULL,
	[nro_atencion] [int] NOT NULL,
	[nro_centroMedico] [int] NOT NULL,
	[id_practica] [int] NOT NULL,
	[porc_descuento] [int] NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_DetalleAtencionMedica] PRIMARY KEY CLUSTERED 
(
	[nro_atencion] ASC,
	[nro_centroMedico] ASC,
	[id_practica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DetalleAtencionMedica] ([fecha_atencion], [nro_atencion], [nro_centroMedico], [id_practica], [porc_descuento], [precio]) VALUES (CAST(0x0000A6A900000000 AS DateTime), 1, 1, 3, 50, 300)
/****** Object:  ForeignKey [FK_Barrio_Localidad]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [FK_Barrio_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [FK_Barrio_Localidad]
GO
/****** Object:  ForeignKey [FK_Afiliado_TipoAfiliado]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_TipoAfiliado] FOREIGN KEY([id_tipoAfiliado])
REFERENCES [dbo].[TipoAfiliado] ([id_tipoAfiliado])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_TipoAfiliado]
GO
/****** Object:  ForeignKey [FK_Afiliado_TipoDoc]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_TipoDoc] FOREIGN KEY([id_tipoDoc])
REFERENCES [dbo].[TipoDoc] ([id_tipoDoc])
GO
ALTER TABLE [dbo].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_TipoDoc]
GO
/****** Object:  ForeignKey [FK_CostosXTipoAfiliado_TipoAfiliado]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[CostosXTipoAfiliado]  WITH CHECK ADD  CONSTRAINT [FK_CostosXTipoAfiliado_TipoAfiliado] FOREIGN KEY([id_tipoAfiliado])
REFERENCES [dbo].[TipoAfiliado] ([id_tipoAfiliado])
GO
ALTER TABLE [dbo].[CostosXTipoAfiliado] CHECK CONSTRAINT [FK_CostosXTipoAfiliado_TipoAfiliado]
GO
/****** Object:  ForeignKey [FK_Practica_Especialidad]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Practica]  WITH CHECK ADD  CONSTRAINT [FK_Practica_Especialidad] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[Especialidad] ([id_especialidad])
GO
ALTER TABLE [dbo].[Practica] CHECK CONSTRAINT [FK_Practica_Especialidad]
GO
/****** Object:  ForeignKey [FK_Usuario_Perfil]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
/****** Object:  ForeignKey [FK_Profesional_Barrio]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id_barrio])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesional_Barrio]
GO
/****** Object:  ForeignKey [FK_Profesional_TipoDoc]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_TipoDoc] FOREIGN KEY([id_tipoDoc])
REFERENCES [dbo].[TipoDoc] ([id_tipoDoc])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesional_TipoDoc]
GO
/****** Object:  ForeignKey [FK_GrupoAfiliado_Afiliado]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[GrupoAfiliado]  WITH CHECK ADD  CONSTRAINT [FK_GrupoAfiliado_Afiliado] FOREIGN KEY([id_tipoDocTitular], [nro_docTitular])
REFERENCES [dbo].[Afiliado] ([id_tipoDoc], [nro_doc])
GO
ALTER TABLE [dbo].[GrupoAfiliado] CHECK CONSTRAINT [FK_GrupoAfiliado_Afiliado]
GO
/****** Object:  ForeignKey [FK_GrupoAfiliado_Afiliado1]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[GrupoAfiliado]  WITH CHECK ADD  CONSTRAINT [FK_GrupoAfiliado_Afiliado1] FOREIGN KEY([id_tipoDocFamiliar], [nro_docFamiliar])
REFERENCES [dbo].[Afiliado] ([id_tipoDoc], [nro_doc])
GO
ALTER TABLE [dbo].[GrupoAfiliado] CHECK CONSTRAINT [FK_GrupoAfiliado_Afiliado1]
GO
/****** Object:  ForeignKey [FK_CobroCuotas_Afiliado]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[CobroCuotas]  WITH CHECK ADD  CONSTRAINT [FK_CobroCuotas_Afiliado] FOREIGN KEY([id_tipoDocAfiliado], [nroDocAfiliado])
REFERENCES [dbo].[Afiliado] ([id_tipoDoc], [nro_doc])
GO
ALTER TABLE [dbo].[CobroCuotas] CHECK CONSTRAINT [FK_CobroCuotas_Afiliado]
GO
/****** Object:  ForeignKey [FK_CobroCuotas_Cuota]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[CobroCuotas]  WITH CHECK ADD  CONSTRAINT [FK_CobroCuotas_Cuota] FOREIGN KEY([año], [mes])
REFERENCES [dbo].[Cuota] ([año], [mes])
GO
ALTER TABLE [dbo].[CobroCuotas] CHECK CONSTRAINT [FK_CobroCuotas_Cuota]
GO
/****** Object:  ForeignKey [FK_CentroMedico_Barrio]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[CentroMedico]  WITH CHECK ADD  CONSTRAINT [FK_CentroMedico_Barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id_barrio])
GO
ALTER TABLE [dbo].[CentroMedico] CHECK CONSTRAINT [FK_CentroMedico_Barrio]
GO
/****** Object:  ForeignKey [FK_Afiliacion_Afiliado]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Afiliacion]  WITH CHECK ADD  CONSTRAINT [FK_Afiliacion_Afiliado] FOREIGN KEY([id_tipoDocAfiliado], [nro_docAfiliado])
REFERENCES [dbo].[Afiliado] ([id_tipoDoc], [nro_doc])
GO
ALTER TABLE [dbo].[Afiliacion] CHECK CONSTRAINT [FK_Afiliacion_Afiliado]
GO
/****** Object:  ForeignKey [FK_Afiliacion_PrestacionAdicional]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Afiliacion]  WITH CHECK ADD  CONSTRAINT [FK_Afiliacion_PrestacionAdicional] FOREIGN KEY([cod_prestacionAdicional])
REFERENCES [dbo].[PrestacionAdicional] ([cod_prestacion])
GO
ALTER TABLE [dbo].[Afiliacion] CHECK CONSTRAINT [FK_Afiliacion_PrestacionAdicional]
GO
/****** Object:  ForeignKey [FK_AtencionMedica_Afiliado]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[AtencionMedica]  WITH CHECK ADD  CONSTRAINT [FK_AtencionMedica_Afiliado] FOREIGN KEY([id_tipoDocAfiliado], [nro_docAfiliado])
REFERENCES [dbo].[Afiliado] ([id_tipoDoc], [nro_doc])
GO
ALTER TABLE [dbo].[AtencionMedica] CHECK CONSTRAINT [FK_AtencionMedica_Afiliado]
GO
/****** Object:  ForeignKey [FK_AtencionMedica_CentroMedico]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[AtencionMedica]  WITH CHECK ADD  CONSTRAINT [FK_AtencionMedica_CentroMedico] FOREIGN KEY([nro_centroMedico])
REFERENCES [dbo].[CentroMedico] ([nro_centroMedico])
GO
ALTER TABLE [dbo].[AtencionMedica] CHECK CONSTRAINT [FK_AtencionMedica_CentroMedico]
GO
/****** Object:  ForeignKey [FK_AtencionMedica_Especialidad]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[AtencionMedica]  WITH CHECK ADD  CONSTRAINT [FK_AtencionMedica_Especialidad] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[Especialidad] ([id_especialidad])
GO
ALTER TABLE [dbo].[AtencionMedica] CHECK CONSTRAINT [FK_AtencionMedica_Especialidad]
GO
/****** Object:  ForeignKey [FK_AtencionMedica_Profesional]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[AtencionMedica]  WITH CHECK ADD  CONSTRAINT [FK_AtencionMedica_Profesional] FOREIGN KEY([matricula])
REFERENCES [dbo].[Profesional] ([matricula])
GO
ALTER TABLE [dbo].[AtencionMedica] CHECK CONSTRAINT [FK_AtencionMedica_Profesional]
GO
/****** Object:  ForeignKey [FK_ProfesionalXEspecialidadXCentroMedico_CentroMedico]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico]  WITH CHECK ADD  CONSTRAINT [FK_ProfesionalXEspecialidadXCentroMedico_CentroMedico] FOREIGN KEY([nro_centroMedico])
REFERENCES [dbo].[CentroMedico] ([nro_centroMedico])
GO
ALTER TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico] CHECK CONSTRAINT [FK_ProfesionalXEspecialidadXCentroMedico_CentroMedico]
GO
/****** Object:  ForeignKey [FK_ProfesionalXEspecialidadXCentroMedico_Especialidad]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico]  WITH CHECK ADD  CONSTRAINT [FK_ProfesionalXEspecialidadXCentroMedico_Especialidad] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[Especialidad] ([id_especialidad])
GO
ALTER TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico] CHECK CONSTRAINT [FK_ProfesionalXEspecialidadXCentroMedico_Especialidad]
GO
/****** Object:  ForeignKey [FK_ProfesionalXEspecialidadXCentroMedico_Profesional]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico]  WITH CHECK ADD  CONSTRAINT [FK_ProfesionalXEspecialidadXCentroMedico_Profesional] FOREIGN KEY([matricula])
REFERENCES [dbo].[Profesional] ([matricula])
GO
ALTER TABLE [dbo].[ProfesionalXEspecialidadXCentroMedico] CHECK CONSTRAINT [FK_ProfesionalXEspecialidadXCentroMedico_Profesional]
GO
/****** Object:  ForeignKey [FK_Facturacion_CentroMedico]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_CentroMedico] FOREIGN KEY([nro_centroMedico])
REFERENCES [dbo].[CentroMedico] ([nro_centroMedico])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_CentroMedico]
GO
/****** Object:  ForeignKey [FK_DetalleFacturacion_Facturacion]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[DetalleFacturacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFacturacion_Facturacion] FOREIGN KEY([nro_facturacion], [nro_centroMedico])
REFERENCES [dbo].[Facturacion] ([nro_facturacion], [nro_centroMedico])
GO
ALTER TABLE [dbo].[DetalleFacturacion] CHECK CONSTRAINT [FK_DetalleFacturacion_Facturacion]
GO
/****** Object:  ForeignKey [FK_DetalleFacturacion_Practica]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[DetalleFacturacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFacturacion_Practica] FOREIGN KEY([id_practica])
REFERENCES [dbo].[Practica] ([id_practica])
GO
ALTER TABLE [dbo].[DetalleFacturacion] CHECK CONSTRAINT [FK_DetalleFacturacion_Practica]
GO
/****** Object:  ForeignKey [FK_DetalleAtencionMedica_AtencionMedica]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[DetalleAtencionMedica]  WITH CHECK ADD  CONSTRAINT [FK_DetalleAtencionMedica_AtencionMedica] FOREIGN KEY([nro_atencion], [nro_centroMedico])
REFERENCES [dbo].[AtencionMedica] ([nro_atencion], [nro_centroMedico])
GO
ALTER TABLE [dbo].[DetalleAtencionMedica] CHECK CONSTRAINT [FK_DetalleAtencionMedica_AtencionMedica]
GO
/****** Object:  ForeignKey [FK_DetalleAtencionMedica_Practica]    Script Date: 10/24/2016 20:50:03 ******/
ALTER TABLE [dbo].[DetalleAtencionMedica]  WITH CHECK ADD  CONSTRAINT [FK_DetalleAtencionMedica_Practica] FOREIGN KEY([id_practica])
REFERENCES [dbo].[Practica] ([id_practica])
GO
ALTER TABLE [dbo].[DetalleAtencionMedica] CHECK CONSTRAINT [FK_DetalleAtencionMedica_Practica]
GO
