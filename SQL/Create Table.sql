CREATE TABLE [dbo].[TypeRoom] (
    [TypeId]       INT         NOT NULL,
    [NameRoom]     NCHAR (255) NULL,
    [AC]           BIT         DEFAULT ((0)) NOT NULL,
    [Chair]        BIT         DEFAULT ((0)) NOT NULL,
    [Balcony]      BIT         DEFAULT ((0)) NOT NULL,
    [Bathtub]      BIT         DEFAULT ((0)) NOT NULL,
    [TV]           BIT         DEFAULT ((0)) NOT NULL,
    [Hairdryer]    BIT         DEFAULT ((0)) NOT NULL,
    [Desk]         BIT         DEFAULT ((0)) NOT NULL,
    [Refrigerator] BIT         DEFAULT ((0)) NOT NULL,
    [Pool]         BIT         DEFAULT ((0)) NOT NULL,
    [CoffeeMaker]  BIT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([TypeId] ASC)
);

CREATE TABLE [dbo].[TypeHotel] (
    [HotelType] INT         NOT NULL,
    [TypeName]  NCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([HotelType] ASC)
);

CREATE TABLE [dbo].[Room] (
    [RoomId]      INT         NOT NULL,
    [TypeId]      INT         NOT NULL,
    [RoomName]    NCHAR (255) NOT NULL,
    [RoomNo]      INT         NOT NULL,
    [RoomBed]     INT         DEFAULT ((1)) NOT NULL,
    [RoomPerson]  INT         DEFAULT ((2)) NOT NULL,
    [RoomPrice]   INT         DEFAULT ((100)) NOT NULL,
    [RoomArea]    INT         DEFAULT ((20)) NOT NULL,
    [RoomPicture] IMAGE       NULL,
    PRIMARY KEY CLUSTERED ([RoomId] ASC),
    FOREIGN KEY ([TypeId]) REFERENCES [dbo].[TypeRoom] ([TypeId])
);

CREATE TABLE [dbo].[PersonOrder] (
    [OrderId]    INT  NOT NULL,
    [PersonId]   INT  NOT NULL,
    [RoomId]     INT  NOT NULL,
    [OrderStart] DATE NOT NULL,
    [OrderEnd]   DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]),
    FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Room] ([RoomId])
);

CREATE TABLE [dbo].[Person] (
    [PersonId]          INT         NOT NULL,
    [PersonName]        NCHAR (255) NOT NULL,
    [PersonNumberphone] NCHAR (12)  NOT NULL,
    [PersonEmail]       NCHAR (255) NULL,
    [PersonPassword]    NCHAR (255) NOT NULL,
    [PersonDOB]         DATE        NOT NULL,
    [PersonManager]     BIT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

CREATE TABLE [dbo].[Hotel] (
    [HotelId]          INT         NOT NULL,
    [HotelName]        NCHAR (50)  NOT NULL,
    [HotelAddress]     NCHAR (250) NOT NULL,
    [HotelDescription] NCHAR (250) NOT NULL,
    [HotelType]        INT         NOT NULL,
    [HotelImage]       IMAGE       NULL,
    [HotelHotline]     INT         NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([HotelId] ASC)
);

