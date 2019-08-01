drop database if exists roombooking;
go

create database roombooking;
go

use roombooking;
-- drop table user_table;
create table user_table
	(id			int IDENTITY(1,1) PRIMARY KEY,
	 name		varchar(250) NOT NULL,
	 login		varchar(250) NOT NULL,
	 phone		varchar(15), --(777)123-1234
	 password	varchar(128) NOT NULL 
	);
-- drop table room_table;
create table room_table
	(id			int IDENTITY(1,1) PRIMARY KEY, 
	 number		varchar(15),
	 building	varchar(25), 
	 capacity	numeric(3) check (capacity > 0),
	 resources TEXT --More than one item, like Projector, TV, White Board, Etc.
	);
-- drop table BookedRoom_table;
create table BookedRoom_table
	(id			int IDENTITY(1,1) PRIMARY KEY, 
	 user_id	int, 
	 room_id	int,
	 date_booked DATE,
	 time_start smallint,
	 time_end	 smallint,
	 members_qtt	int check (members_qtt > 0),	 
	 foreign key (user_id) references user_table(id) on delete SET NULL,
	 foreign key (room_id) references room_table(id) on delete SET NULL
	);