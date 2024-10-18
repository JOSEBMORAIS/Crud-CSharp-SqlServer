USE [bancoteste]
GO

/****** Object:  Table [dbo].[Produtos]    Script Date: 17/10/2024 10:05:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produtos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Descricao] [nvarchar](255) NULL,
	[Preco] [decimal](10, 2) NOT NULL,
	[DataCadastro] [datetime] NULL,
	[kit] [int] NULL,
	[classFiscal] [varchar](20) NULL,
	[EstMinimo] [decimal](10, 2) NOT NULL,
	[DataMovto] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Produtos] ADD  DEFAULT (getdate()) FOR [DataCadastro]
GO


