drop table EcoDriving;


create table EcoDriving(
	
id serial primary key,
	
userId integer references ecodrivepeople(id),
	
driveNum integer,
	
frameNumber integer,
	
frameTime integer,
	
rpm integer,
	
speed integer,
	
fuelConsumption text,
	
distance integer,
	
currentFuelConsumption varchar(5),
	
enginePower integer
);




--Insert into EcoDriving (frameNumber,frameTime,rpm,speed,fuelConsumption,distance,currentFuelConsumption,enginePower) values 
--                       (16,'1391','1282','8','0.008000,0.008000,0.008000,0.000000,0.008000,0.008000','0','16,8','3');

delete from EcoDriving;

select * from EcoDriving; where enginepower > 27;

-- Insert into EcoDrivePeople (name,surname) values ('Romek','Chmura');

select * from ecodrivepeople;
drop table ecodrivepeople;
create table ecodrivepeople (
	id serial primary key,
	name text,
	surname text,
	driveNum integer
);

