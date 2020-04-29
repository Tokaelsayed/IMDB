--------------------------------------------------------
--  File created - Friday-April-10-2020   
--------------------------------------------------------
  DROP TABLE "ACTOR" cascade constraints;
  DROP TABLE "DIRECTOR" cascade constraints;
  DROP TABLE "IMDB_USER" cascade constraints;
  DROP TABLE "MOVIE" cascade constraints;
  DROP TABLE "MOVIECATEGORY" cascade constraints;
  DROP TABLE "MOVIE_ACTOR" cascade constraints;
  DROP TABLE "USER_RATE" cascade constraints;
  DROP TABLE "USER_REVIEW" cascade constraints;
  DROP TABLE "USER_SEARCH" cascade constraints;
  DROP PROCEDURE "GETUSERID";
  DROP PROCEDURE "INSERT_NEW_USER";
--------------------------------------------------------
--  DDL for Table ACTOR
--------------------------------------------------------

  CREATE TABLE "ACTOR" 
   (	"ACTOR_ID" NUMBER, 
	"ACTOR_NAME" VARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table DIRECTOR
--------------------------------------------------------

  CREATE TABLE "DIRECTOR" 
   (	"DIR_ID" NUMBER, 
	"DIR_NAME" VARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table IMDB_USER
--------------------------------------------------------

  CREATE TABLE "IMDB_USER" 
   (	"USER_ID" NUMBER, 
	"FIRST_NAME" VARCHAR2(20), 
	"SECOND_NAME" VARCHAR2(20), 
	"PASSWORD" VARCHAR2(80), 
	"USER_NAME" VARCHAR2(80)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table MOVIECATEGORY
--------------------------------------------------------

  CREATE TABLE "MOVIECATEGORY" 
   (	"CATEGORYID" NUMBER, 
	"CATEGORYNAME" VARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table MOVIE
--------------------------------------------------------

  CREATE TABLE "MOVIE" 
   (	"MOVIE_NAME" VARCHAR2(80), 
	"DATE_OF_PUPLISH" DATE, 
	"DIRECTOR_ID" NUMBER, 
	"CATEGORY_ID" NUMBER, 
	"IMAGE" BLOB
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" 
 LOB ("IMAGE") STORE AS BASICFILE (
  TABLESPACE "USERS" ENABLE STORAGE IN ROW CHUNK 8192 RETENTION 
  NOCACHE LOGGING 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)) ;
--------------------------------------------------------
--  DDL for Table MOVIE_ACTOR
--------------------------------------------------------

  CREATE TABLE "MOVIE_ACTOR" 
   (	"MOVIE_NAME" VARCHAR2(80), 
	"ACTOR_ID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USER_RATE
--------------------------------------------------------

  CREATE TABLE "USER_RATE" 
   (	"USER_ID" NUMBER, 
	"MOVIE_NAME" VARCHAR2(80), 
	"RATE_NUMBER" NUMBER
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USER_REVIEW
--------------------------------------------------------

  CREATE TABLE "USER_REVIEW" 
   (	"USER_ID" NUMBER, 
	"MOVIE_NAME" VARCHAR2(80)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USER_SEARCH
--------------------------------------------------------

  CREATE TABLE "USER_SEARCH" 
   (	"USER_ID" NUMBER, 
	"MOVIE_NAME" VARCHAR2(80)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;

---------------------------------------------------
--   DATA FOR TABLE USER_REVIEW
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USER_REVIEW

---------------------------------------------------
--   END DATA FOR TABLE USER_REVIEW
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE MOVIECATEGORY
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MOVIECATEGORY
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (1,'Adventure');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (2,'Comedy');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (3,'Action');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (4,'Animation');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (5,'Fantasy');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (6,'Drama');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (7,'Romance');
Insert into MOVIECATEGORY (CATEGORYID,CATEGORYNAME) values (8,'Horror');

---------------------------------------------------
--   END DATA FOR TABLE MOVIECATEGORY
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE IMDB_USER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into IMDB_USER
Insert into IMDB_USER (USER_ID,FIRST_NAME,SECOND_NAME,PASSWORD,USER_NAME) values (1,'ebtihal','sherif','111','ebtihal');
Insert into IMDB_USER (USER_ID,FIRST_NAME,SECOND_NAME,PASSWORD,USER_NAME) values (2,'aya','tabey','222','ayaalla');
Insert into IMDB_USER (USER_ID,FIRST_NAME,SECOND_NAME,PASSWORD,USER_NAME) values (3,'tokaa','elsayed','333','tokka');

---------------------------------------------------
--   END DATA FOR TABLE IMDB_USER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ACTOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ACTOR
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (1,' emma watson');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (2,'daniel radcliffe');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (3,'rupert grint');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (4,'alan rickman');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (6,'Robert Pattinson');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (7,'Taylor Lautner');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (8,'Ralph Fiennes');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (9,'Hank Azaria');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (10,'Neil Patrick Harris');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (11,'Jayma Mays');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (12,'Sofia Vergara');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (13,'John Cleese');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (14,'Jim Cummings');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (15,'Bud Luckey');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (16,'Tom Hanks');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (17,'Tim Allen');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (18,'Joan Cusack');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (19,'Mike Myers');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (20,'Eddie Murphy');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (21,'Cameron Diaz');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (22,'Kevin James');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (23,'Salma Hayek');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (24,'Henry Winkler');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (25,'Matthew McConaughey');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (26,'Anne Hathaway');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (27,'Jessica Chastain');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (28,'Sandra Bullock');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (29,'George Clooney');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (30,'Will Smith');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (31,'Tommy Lee Jones');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (5,'Kristen Stewart');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (32,'chris evans');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (33,'robert downey');
Insert into ACTOR (ACTOR_ID,ACTOR_NAME) values (34,'mark rufallo');

---------------------------------------------------
--   END DATA FOR TABLE ACTOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE DIRECTOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into DIRECTOR
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (1,'david yates');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (2,'joss whedon');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (3,'steven spielberg');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (4,'woody allen');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (6,'tim burton');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (7,'christopher nolan');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (8,'hayao miyazaki');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (9,'peter jackson');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (5,'martin scorsese');
Insert into DIRECTOR (DIR_ID,DIR_NAME) values (10,'joe russo');

---------------------------------------------------
--   END DATA FOR TABLE DIRECTOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE MOVIE_ACTOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MOVIE_ACTOR
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Avengers Endgame',32);
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Avengers Endgame',33);
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Avengers Endgame',34);
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Harry Potter and the philosopheres stone',1);
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Harry Potter and the philosopheres stone',2);
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Harry Potter and the philosopheres stone',3);
Insert into MOVIE_ACTOR (MOVIE_NAME,ACTOR_ID) values ('Harry Potter and the philosopheres stone',4);

---------------------------------------------------
--   END DATA FOR TABLE MOVIE_ACTOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE USER_SEARCH
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USER_SEARCH

---------------------------------------------------
--   END DATA FOR TABLE USER_SEARCH
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE USER_RATE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USER_RATE

---------------------------------------------------
--   END DATA FOR TABLE USER_RATE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE MOVIE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MOVIE
Insert into MOVIE (MOVIE_NAME,DATE_OF_PUPLISH,DIRECTOR_ID,CATEGORY_ID,IMAGE) values ('Harry Potter and the philosopheres stone',to_timestamp('16-NOV-01 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1,5,null);
Insert into MOVIE (MOVIE_NAME,DATE_OF_PUPLISH,DIRECTOR_ID,CATEGORY_ID,IMAGE) values ('interstellar',to_timestamp('07-NOV-14 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),7,1,null);
Insert into MOVIE (MOVIE_NAME,DATE_OF_PUPLISH,DIRECTOR_ID,CATEGORY_ID,IMAGE) values ('Avengers Endgame',to_timestamp('22-APR-19 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),10,1,null);
Insert into MOVIE (MOVIE_NAME,DATE_OF_PUPLISH,DIRECTOR_ID,CATEGORY_ID,IMAGE) values ('spiritd away',to_timestamp('20-JUL-01 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),8,4,null);
Insert into MOVIE (MOVIE_NAME,DATE_OF_PUPLISH,DIRECTOR_ID,CATEGORY_ID,IMAGE) values ('howl moving castle',to_timestamp('05-SEP-04 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),8,4,null);

---------------------------------------------------
--   END DATA FOR TABLE MOVIE
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table ACTOR
--------------------------------------------------------

  ALTER TABLE "ACTOR" ADD CONSTRAINT "ACTOR_PK" PRIMARY KEY ("ACTOR_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "ACTOR" MODIFY ("ACTOR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "ACTOR" MODIFY ("ACTOR_NAME" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table DIRECTOR
--------------------------------------------------------

  ALTER TABLE "DIRECTOR" ADD CONSTRAINT "DIRECTOR_PK" PRIMARY KEY ("DIR_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "DIRECTOR" MODIFY ("DIR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "DIRECTOR" MODIFY ("DIR_NAME" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table IMDB_USER
--------------------------------------------------------

  ALTER TABLE "IMDB_USER" ADD CONSTRAINT "IMDB_USER_PK" PRIMARY KEY ("USER_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "IMDB_USER" ADD CONSTRAINT "IMDB_USER_UK1" UNIQUE ("USER_NAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "IMDB_USER" MODIFY ("USER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "IMDB_USER" MODIFY ("FIRST_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "IMDB_USER" MODIFY ("SECOND_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "IMDB_USER" MODIFY ("PASSWORD" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table MOVIE
--------------------------------------------------------

  ALTER TABLE "MOVIE" ADD CONSTRAINT "MOVIE_PK" PRIMARY KEY ("MOVIE_NAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "MOVIE" MODIFY ("MOVIE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "MOVIE" MODIFY ("DATE_OF_PUPLISH" NOT NULL ENABLE);
 
  ALTER TABLE "MOVIE" MODIFY ("DIRECTOR_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table MOVIECATEGORY
--------------------------------------------------------

  ALTER TABLE "MOVIECATEGORY" ADD PRIMARY KEY ("CATEGORYID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table MOVIE_ACTOR
--------------------------------------------------------

  ALTER TABLE "MOVIE_ACTOR" ADD CONSTRAINT "MOVIE_ACTOR_PK" PRIMARY KEY ("MOVIE_NAME", "ACTOR_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "MOVIE_ACTOR" MODIFY ("MOVIE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "MOVIE_ACTOR" MODIFY ("ACTOR_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table USER_RATE
--------------------------------------------------------

  ALTER TABLE "USER_RATE" MODIFY ("USER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "USER_RATE" MODIFY ("MOVIE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "USER_RATE" MODIFY ("RATE_NUMBER" NOT NULL ENABLE);
 
  ALTER TABLE "USER_RATE" ADD CONSTRAINT "USER_RATE_PK" PRIMARY KEY ("USER_ID", "MOVIE_NAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS NOCOMPRESS LOGGING
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USER_REVIEW
--------------------------------------------------------

  ALTER TABLE "USER_REVIEW" MODIFY ("USER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "USER_REVIEW" MODIFY ("MOVIE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "USER_REVIEW" ADD CONSTRAINT "USER_REVIEW_PK" PRIMARY KEY ("USER_ID", "MOVIE_NAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS NOCOMPRESS LOGGING
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USER_SEARCH
--------------------------------------------------------

  ALTER TABLE "USER_SEARCH" MODIFY ("USER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "USER_SEARCH" MODIFY ("MOVIE_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "USER_SEARCH" ADD CONSTRAINT "USER_SEARCH_PK" PRIMARY KEY ("USER_ID", "MOVIE_NAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS NOCOMPRESS LOGGING
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  DDL for Index ACTOR_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ACTOR_PK" ON "ACTOR" ("ACTOR_ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index DIRECTOR_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "DIRECTOR_PK" ON "DIRECTOR" ("DIR_ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index IMDB_USER_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "IMDB_USER_PK" ON "IMDB_USER" ("USER_ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index IMDB_USER_UK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "IMDB_USER_UK1" ON "IMDB_USER" ("USER_NAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index MOVIE_ACTOR_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MOVIE_ACTOR_PK" ON "MOVIE_ACTOR" ("MOVIE_NAME", "ACTOR_ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index MOVIE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MOVIE_PK" ON "MOVIE" ("MOVIE_NAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USER_RATE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USER_RATE_PK" ON "USER_RATE" ("USER_ID", "MOVIE_NAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USER_REVIEW_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USER_REVIEW_PK" ON "USER_REVIEW" ("USER_ID", "MOVIE_NAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USER_SEARCH_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USER_SEARCH_PK" ON "USER_SEARCH" ("USER_ID", "MOVIE_NAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;



--------------------------------------------------------
--  Ref Constraints for Table MOVIE
--------------------------------------------------------

  ALTER TABLE "MOVIE" ADD CONSTRAINT "MOVIE_CATEGORY" FOREIGN KEY ("CATEGORY_ID")
	  REFERENCES "MOVIECATEGORY" ("CATEGORYID") ENABLE;
 
  ALTER TABLE "MOVIE" ADD CONSTRAINT "MOVIE_DIRECTOR_RELATION" FOREIGN KEY ("DIRECTOR_ID")
	  REFERENCES "DIRECTOR" ("DIR_ID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table MOVIE_ACTOR
--------------------------------------------------------

  ALTER TABLE "MOVIE_ACTOR" ADD CONSTRAINT "MOVIE_ACTORID_RELATION" FOREIGN KEY ("ACTOR_ID")
	  REFERENCES "ACTOR" ("ACTOR_ID") ENABLE;
 
  ALTER TABLE "MOVIE_ACTOR" ADD CONSTRAINT "MOVIE_ACTOR_RELATION" FOREIGN KEY ("MOVIE_NAME")
	  REFERENCES "MOVIE" ("MOVIE_NAME") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USER_RATE
--------------------------------------------------------

  ALTER TABLE "USER_RATE" ADD CONSTRAINT "MOVIE_RATE_RELATION" FOREIGN KEY ("MOVIE_NAME")
	  REFERENCES "MOVIE" ("MOVIE_NAME") ENABLE;
 
  ALTER TABLE "USER_RATE" ADD CONSTRAINT "USER_RATE_RELATION" FOREIGN KEY ("USER_ID")
	  REFERENCES "IMDB_USER" ("USER_ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USER_REVIEW
--------------------------------------------------------

  ALTER TABLE "USER_REVIEW" ADD CONSTRAINT "MOVIE_REVIEW_RELATION" FOREIGN KEY ("MOVIE_NAME")
	  REFERENCES "MOVIE" ("MOVIE_NAME") ENABLE;
 
  ALTER TABLE "USER_REVIEW" ADD CONSTRAINT "USER_REVIEW_RELATION" FOREIGN KEY ("USER_ID")
	  REFERENCES "IMDB_USER" ("USER_ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USER_SEARCH
--------------------------------------------------------

  ALTER TABLE "USER_SEARCH" ADD CONSTRAINT "MOVIE_USER_SEARCH_RELATION" FOREIGN KEY ("MOVIE_NAME")
	  REFERENCES "MOVIE" ("MOVIE_NAME") ENABLE;
 
  ALTER TABLE "USER_SEARCH" ADD CONSTRAINT "USER_SEARCH_RELATION" FOREIGN KEY ("USER_ID")
	  REFERENCES "IMDB_USER" ("USER_ID") ENABLE;
--------------------------------------------------------
--  DDL for Procedure GETUSERID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETUSERID" 
(UID out number)
as
begin
select max(user_id)
into UID
from imdb_user;
end;

/

--------------------------------------------------------
--  DDL for Procedure INSERT_NEW_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERT_NEW_USER" 
(UID number, FName VARCHAR2,LName VARCHAR2,
Pass VARCHAR ,UName VARCHAR2 )
as
begin
insert  into  imdb_user
(USER_ID, FIRST_NAME,SECOND_NAME, PASSWORD, user_name)
Values ( UID,FName,LName,Pass,UName);
End ;

/

