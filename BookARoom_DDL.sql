drop database if exists RoomApp;
go

create database RoomApp;
go

use RoomApp;

create table user_table
	(id			int IDENTITY(1,1) PRIMARY KEY,
	 phone		varchar(15), --(777)123-1234
	 name		varchar(250) NOT NULL,
	 password	varchar(128) NOT NULL 
	);

create table room_table
	(id			int IDENTITY(1,1) PRIMARY KEY, 
	 number		varchar(15),
	 location	varchar(15), 
	 capacity	numeric(3) check (capacity > 0),
	 resources TEXT
	);

create table BookedRoom_table
	(id			int IDENTITY(1,1) PRIMARY KEY, 
	 user_id	int, 
	 room_id	int,
	 date_time_start date,
	 date_time_end	 date,
	 members_qtt	int check (members_qtt > 0),	 
	 foreign key (user_id) references user_table(id) on delete SET NULL,
	 foreign key (room_id) references room_table(id) on delete SET NULL
	);