CREATE DATABASE [Microsoft.TailWindTraders.Product]
GO
USE [Microsoft.TailWindTraders.Product]
GO
/****** Object:  Table [dbo].[ProductBrands]    Script Date: 3/11/2019 9:14:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductBrands](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductBrands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductFeatures]    Script Date: 3/11/2019 9:14:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductFeatures](
	[Id] [int] NOT NULL,
	[ProductItemId] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductFeatures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductItems]    Script Date: 3/11/2019 9:14:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductItems](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [real] NOT NULL,
	[ImageName] [nvarchar](max) NULL,
	[BrandId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[TagId] [int] NULL,
 CONSTRAINT [PK_ProductItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 3/11/2019 9:14:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](450) NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 3/11/2019 9:14:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (1, N'ElctroDrill')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (2, N'Home & Pro tools')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (3, N'Pro Saws')
INSERT [dbo].[ProductBrands] ([Id], [Name]) VALUES (4, N'Drills Co')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (1, 1, N'20 Litre', N'Create delicious meals with this 800 W manual microwave with a 20 Litre capacity')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (2, 1, N'Multipower', N'Six power levels including a defrost setting offers variety for your cooking requirements')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (3, 1, N'3 years guarantee', N'3 years guarantee')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (4, 1, N'Key features', N'20Litre capacity (0.7cu.ft) 800W microwave output 11 microwave power levels 99min timer Cooking end signal Auto cook menus Defrost setting Glass turntable Mirror door')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (5, 1, N'Triple Distribution System', N'Meaning a more even and effective distribution of heat. Easytronics dial control')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (6, 2, N'Low Noise', N'Thermoelectric technology is almost silent, so your kitchen stays quiet')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (7, 2, N'Stylish', N'Stylish American Style, Side by side Fridge freezer with energy rating A+')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (8, 2, N'Great capacity', N'510 litre capacity - holds 28 bags of food shopping')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (9, 3, N'Double Hotplate', N'Enjoy the bonus feature of including 2 ceramic hotplates, which are positioned on the top of the mini oven and are suitable for use with any kind of pot, pan, and frying pan for boiling, steaming, warming, or frying.')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (10, 3, N'2-year warranty', N'Shop with confidence. Your Oven with is covered by a 2 year manufacturer''s warranty')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (11, 4, N'9k capacity', N'9kg drum capacity ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (12, 4, N'A+++', N'A+++ energy rating')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (13, 5, N'1600rpm', N'1600rpm max spin speed ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (14, 5, N'15 wash programmes ', N'15 wash programmes ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (15, 6, N'Silver', N'Colour Silver ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (16, 6, N'Eco-Friendly ', N'Eco-Friendly ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (17, 6, N'Size', N'Approx. 27x27cm')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (18, 7, N'Capacity', N'141 Litres Fridge Capacity')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (19, 8, N'Interface', N' inlet: G1 / 2, outlet: G1 / 4.')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (20, 9, N'Leakproof', N'The shower arm diverter is made by top premium brass with disc cartridge for leakproof and durability warranty')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (21, 10, N'Pinhole', N'The pinhole is out of the water, the water is slender and soft, and there is no pain in the body. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (22, 10, N'Interface', N'The interface is suitable for most home use, hoses, showers, and interfaces are 2cm in diameter. It is suitable for all types of water heaters. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (23, 11, N'Portable battery', N'Battery powered portable bidet (rechargeable) can be taken anywhere ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (24, 11, N'10 wash cycles', N'Minimum 50 wash cycles between charge & 10 wash cycles per 1.5 litre reservoir ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (25, 11, N'Remote handset', N'Operates from a simple remote handset ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (26, 12, N'Multifunction', N'Not only ideal for dog shower in bathroom, but also can be used as handheld bidet for personal hygiene etc. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (27, 12, N'Handheld dog shower', N'Comes with handheld dog shower sprayer head, hand shower arm diverter')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (28, 13, N'Single and double tap', N'Single tap type and double tap type available, fit for most of standard taps. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (29, 13, N'Pet washing', N'Can be used for pet washing, help you to take care of your cat or dog at ease and keep them clean.')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (30, 13, N'Light weight', N'Light weight, soft and flexible, easy to install and convenient to use. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (31, 14, N'Chrome finished', N'Chrome finish to create a bright, highly reflective, guaranteed not to tarnish or corrode Bathroom Sink faucet ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (32, 14, N'Ceramic disc', N'Ceramic disc cartridge for smooth and long lasting operation bathtub sink faucet ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (33, 15, N'Single handle', N'Single handle easy control of hot and cold water, Single hole easy installation basin mixer tap ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (34, 15, N'Durable', N'Durable lead-free solid brass construction. waterfall widespread vintage style bathroom vessel sink mixer tap, tall body ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (35, 16, N'Chrome finished', N'This universal bath shower head is made of high grade ABS. Chrome finish ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (36, 17, N'Ready made', N'Two Panels Per Package, Each panel measures 117 x 138cm Drop, Inner Diameter of the Each Ring Measures 4cm. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (37, 18, N'Only hardware', N'Only Hardware is sold, the door is not included. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (38, 19, N'Thermal curtains', N'These thermal blackout curtains are made of 100 percent polyester and are imported. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (39, 20, N'3 Year Guarantee ', N'3 Year Guarantee ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (40, 21, N'Telescoping rod', N'Telescoping double rod has a 3/4-inch diameter front rod and 5/8-inch diameter back rod, and is available in 3 sizes to accommodate most windows ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (41, 21, N'Easy setup', N'Your Twilight double curtain rod comes with everything you need to get set up quickly and doesn''t require a curtain rod bracket')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (42, 22, N'Brushed steel', N'Brushed Stainless Steel Door Knob Handle Passage Entrance Privacy Thumb Lock ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (43, 23, N'Woodgrain effect ', N'Woodgrain effect ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (44, 23, N'Primed finish-ready', N'Primed finish-ready to paint')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (45, 24, N'Real wood', N'Natural real wood venetian blinds ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (46, 24, N'Metal brackets', N'Metal brackets that can be top, side or face fixed ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (47, 25, N'9 plants size', N'Up to 9 plants can be grown at a time. Plants grow in water, not soil. Advanced hydroponics made simple, Enjoy plants all year round. Grow fresh herbs, vegetables, salad leaves, flowers and more in this smart indoor garden ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (48, 26, N'Wood material', N'Wood material')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (49, 27, N'Galvanised steel ', N'Durable galvanised steel ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (50, 28, N'85L capacity', N'Capacity: 85 Litres / 120 Kgs ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (51, 29, N'Tissue holder ', N'Tissue holder ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (52, 30, N'Stainless fork', N'Stainless Steel Weed Fork with 40-Inch Handle ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (53, 31, N'22cm high', N'Stands approx. 22cm high ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (54, 31, N'Tree pack', N'Christmas tree pack')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (55, 32, N'6 feet tall', N'6 feet tall Christmas Tree in plain green with 1000 tips, pvc material is suitable for both outdoor and indoor using. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (56, 32, N'Foldable base', N'Designed with a durable metal body to use season after season, plus a foldable base for easy assembly. ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (57, 33, N'Material', N'Green plastic')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (58, 34, N'9 feet tall', N'9 feet tall Christmas tree')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (59, 35, N'Natural pine', N'Our natural wood slices are made of natural pine wood with barks and clearly visible wood grain.')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (60, 35, N'High-quality', N'Our wood slices were drying, slicing, and picking out high-quality wood chips')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (61, 36, N'Dining table', N'A solid oak rectangular dining table in a durable oiled finish ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (62, 36, N'Dimensions', N'Dimensions (D x W x H): 118 x 75 x 75 cm ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (63, 37, N'Folding foot', N'Folding foot, Piezo ignition, wind shield ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (64, 38, N'Double ceramic coating', N'Double ceramic coating, aluminium cookware set ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (65, 39, N'Stylish machine', N'Stylish bean-to-cup espresso/cappuccino machine with professional 15-bar pump pressure')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (66, 40, N'Ventilation mode', N'Recirculation inside your kitchen with the use of carbon filters.')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (67, 41, N'Small commode', N'Upholstered commode chair is small, easier to move around the patient''s room, at home or in clinical setting.')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (68, 42, N'Easy setup', N'Provided with detailed instructions, the cubes are easy to assemble; and can be installed on the wall seamlessly with the screws and cloaking metal plates ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (69, 43, N'Large bay size', N'1500mm High x 700mm Wide x 300mm Deep and capable of holding 180kg per shelf ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (70, 44, N'Modern design', N'Wood-patterned closed doors and walls')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (71, 45, N'High carbon steel blade', N'High carbon steel blade for use in hard-to-reach areas ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (72, 46, N'Tylon blade coating', N'Tylon blade coating gives durability and wear resistance than lacquer')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (73, 47, N'Vibration absorbing handle ', N'Vibration absorbing handle ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (74, 48, N'Forged black', N'Forged black painted head ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (75, 48, N'Polished faces', N'Hardened and tempered with polished faces and hardwood shaft ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (76, 49, N'Chrome vanadium steel ', N'Manufactured from chrome vanadium steel ')
INSERT [dbo].[ProductFeatures] ([Id], [ProductItemId], [Title], [Description]) VALUES (77, 50, N'Hardened and tempered ', N'Carbon steel hardened and tempered ')
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (1, N'Microwave 0.9 Cu. Ft. 900 W', 100, N'10446729.jpg', 1, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (2, N'Refrigerator 1.7 cu. ft. 110 watts', 200, N'24640268.jpg', 3, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (3, N'Oven 900 W', 300, N'26881473.jpg', 4, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (4, N'Washing machine 1200rpm', 400, N'31000074.jpg', 2, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (5, N'Washing machine 900rpm', 300, N'31285507.jpg', 1, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (6, N'Kitchen stoves ', 1400, N'33641114.jpg', 2, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (7, N'Refrigerator ft. 90 watts', 400, N'45808024.jpg', 3, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (8, N'One Handle Stainless Steel Pull Out Kitchen Faucet', 20, N'47090355.jpg', 3, 1, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (9, N'Bathing System Classic 18 in. H x 60 in. W x 32.5', 200, N'12330912.jpg', 1, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (10, N'Showerhead 1.75 gpm', 40, N'12866014.jpg', 1, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (11, N'Toilet 1.28 gal.', 180, N'20155731.jpg', 1, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (12, N'Black Bathing System Classic 18 in. H x 60 in. W x 32.5', 250, N'24547395.jpg', 2, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (13, N'Bathroom Sink Faucet Waterfall', 175, N'25200686.jpg', 2, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (14, N'Bathroom Sink Faucet', 99, N'40193368.jpg', 2, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (15, N'Bathroom Sink Faucet Classic', 100, N'40887643.jpg', 3, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (16, N'Showerhead 1.20 gpm', 125, N'46028385.jpg', 3, 2, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (17, N'Blend Solid White Sheer Curtains', 110, N'13778772.jpg', 3, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (18, N'Door Hardware Kit Single Door', 120, N'17031875.jpg', 4, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (19, N'White Sheer Curtains', 105, N'27367695.jpg', 4, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (20, N'White Window', 120, N'34744564.jpg', 4, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (21, N'Curtain Rod 48 in', 25, N'35268457.jpg', 4, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (22, N'Steel Passage Door Knob', 10, N'39689828.jpg', 1, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (23, N'White Door', 123, N'40505435.jpg', 1, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (24, N'White Window Wood', 230, N'46655256.jpg', 1, 3, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (25, N'Indoor Kit Gardering', 70, N'9470575.jpg', 3, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (26, N'Craftsman 100 ft. L x 5/8 in.', 100, N'12598356.jpg', 3, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (27, N'Metal Watering Can', 20, N'12902526.jpg', 3, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (28, N'Steel Contractor Wheelbarrow', 100, N'13894399.jpg', 3, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (29, N'Craftsman 21 in. W 140', 200, N'15365639.jpg', 3, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (30, N'Gardering', 10, N'29201547.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (31, N'Celebrations C9', 10, N'16658158.jpg', 2, 5, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (32, N'Artificial Tree', 250, N'23073793.jpg', 2, 5, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (33, N'Celebrations C8', 5, N'23536846.jpg', 2, 5, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (34, N'Artificial Tree Big', 300, N'23980448.jpg', 2, 5, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (35, N'Wood Pack', 30, N'31434677.jpg', 1, 5, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (36, N'Wood Table', 395, N'19806834.jpg', 1, 6, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (37, N'Kitchen Stoves', 85, N'27227580.jpg', 1, 6, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (38, N'Kit Metal Casseroles', 125, N'43229847.jpg', 4, 6, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (39, N'Coffee Maker Red', 200, N'52076809.jpg', 4, 6, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (40, N'Extractor Steal', 135, N'102013777.jpg', 4, 6, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (41, N'Wooden Commode', 50, N'21610747.jpg', 1, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (42, N'Metal Shelving', 90, N'39696958.jpg', 1, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (43, N'Big Metal Shelving', 99, N'49460165.jpg', 2, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (44, N'Wooden Wardrobe', 120, N'51716553.jpg', 2, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (45, N'Wooden Saw', 145, N'11143240.jpg', 3, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (46, N'Measuring Tape', 123, N'13168288.jpg', 3, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (47, N'Multi Function Drill', 159, N'14805480.jpg', 2, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (48, N'Hammer', 100, N'19682904.jpg', 2, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (49, N'Screwdriver', 110, N'51109515.jpg', 1, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (50, N'Pliers', 105, N'85167541.jpg', 1, 7, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (51, N'Red multi-tool plier', 50, N'34312289.jpg', 1, 7, 2)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (52, N'Blue multi-tool plier', 50, N'19595793.jpg', 1, 7, 2)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (53, N'Stainless multi-tool plier', 90, N'35414723.jpg', 1, 7, 2)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (54, N'Yellow Rechargeable screwdriver', 250, N'8704649.jpg', 2, 7, 1)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (55, N'Red Rechargeable screwdriver', 250, N'6910004.jpg', 1, 7, 1)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (56, N'Rechargeable screwdriver with extra battery', 312, N'63581524.jpg', 2, 7, 1)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (57, N'Yellow hard hat with tool bag pack', 46, N'59890052.jpg', 3, 7, 3)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (58, N'Single red garden gnome', 56, N'6112251.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (59, N'Two red garden gnomes', 92, N'10999322.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (60, N'One sat gnome', 34, N'24639790.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (61, N'One sat on shoe gnome', 54, N'24639792.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (62, N'One barrow gnome', 29, N'34369812.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (63, N'One glasses gnome', 54, N'34369851.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (64, N'One smiling gnome', 43, N'38786528.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (65, N'Two singing gnomes', 65, N'44333595.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (66, N'Two sleeping gnomes', 32, N'76911883.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (67, N'Seven-pack gnomes', 250, N'91797131.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (68, N'One afraid gnome', 39, N'106662449.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (69, N'One welcome gnome', 28, N'106906828.jpg', 2, 4, NULL)
INSERT [dbo].[ProductItems] ([Id], [Name], [Price], [ImageName], [BrandId], [TypeId], [TagId]) VALUES (70, N'Two smiling gnomes', 76, N'106906834.jpg', 2, 4, NULL)
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (1, N'Home Appliances', N'homeappliances')
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (2, N'Sink', N'sink')
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (3, N'Home', N'home')
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (4, N'Gardening', N'gardening')
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (5, N'Decor', N'decor')
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (6, N'Kitchen Accessories', N'kitchen')
INSERT [dbo].[ProductTypes] ([Id], [Name], [Code]) VALUES (7, N'DIY tools', N'diytools')
INSERT [dbo].[Tags] ([Id], [Value]) VALUES (1, N'Rechargeable Screwdriver')
INSERT [dbo].[Tags] ([Id], [Value]) VALUES (2, N'Multitool')
INSERT [dbo].[Tags] ([Id], [Value]) VALUES (3, N'HardHat')
ALTER TABLE [dbo].[ProductFeatures]  WITH CHECK ADD  CONSTRAINT [FK_ProductFeatures_ProductItems_ProductItemId] FOREIGN KEY([ProductItemId])
REFERENCES [dbo].[ProductItems] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductFeatures] CHECK CONSTRAINT [FK_ProductFeatures_ProductItems_ProductItemId]
GO
ALTER TABLE [dbo].[ProductItems]  WITH CHECK ADD  CONSTRAINT [FK_ProductItems_ProductBrands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[ProductBrands] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductItems] CHECK CONSTRAINT [FK_ProductItems_ProductBrands_BrandId]
GO
ALTER TABLE [dbo].[ProductItems]  WITH CHECK ADD  CONSTRAINT [FK_ProductItems_ProductTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[ProductTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductItems] CHECK CONSTRAINT [FK_ProductItems_ProductTypes_TypeId]
GO
ALTER TABLE [dbo].[ProductItems]  WITH CHECK ADD  CONSTRAINT [FK_ProductItems_Tags_TagId] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tags] ([Id])
GO
ALTER TABLE [dbo].[ProductItems] CHECK CONSTRAINT [FK_ProductItems_Tags_TagId]
GO
