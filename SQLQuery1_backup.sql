use master

GO
BACKUP DATABASE [MULTIPLE_CHOICE] TO DISK = 'D:\code_ou\db_btl.bak' WITH COMPRESSION, INIT, STATS = 5;
GO