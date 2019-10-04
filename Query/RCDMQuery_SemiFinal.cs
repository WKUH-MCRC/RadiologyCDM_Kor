
drop table Radiology_hospital;
drop table Radiology_Person_Position;
drop table Radiology_Dose_Units;
drop table Radiology_Exposure_Units;
drop table Radiology_condition;
drop table Radiology_occurrence;
drop table Radiology_image;
drop table Radiology_modality;
drop table radiology_device;
drop table radiology_protocol;
drop table radiology_units;

SELECT * FROM Radiology_hospital;
SELECT * FROM Radiology_Person_Position;
SELECT * FROM Radiology_Dose_Units;
SELECT * FROM Radiology_Exposure_Units;
SELECT * FROM Radiology_condition;
SELECT * FROM Radiology_occurrence;
SELECT * FROM Radiology_image;
SELECT * FROM Radiology_modality;
SELECT * FROM radiology_device;
SELECT * FROM radiology_protocol;
SELECT * FROM radiology_units;




create table Radiology_hospital (
  text          		varchar(50),
  value					integer
 
);


insert into Radiology_hospital (text, value ) values ('WKUH', 10000001);
insert into Radiology_hospital (text, value) values ('SNUH', 10000002);


create table Radiology_Person_Position (
  text          		varchar(50),
  value					integer,
  description	varchar(50)
	
	
);

insert into Radiology_Person_Position (text, value, description) values ('NONE', 20000000, 'Empty Position');
insert into Radiology_Person_Position (text, value, description) values ('HFP', 20000001, 'Head First-Prone');
insert into Radiology_Person_Position (text, value, description) values ('HFS', 20000002, 'Head First-Supine');
insert into Radiology_Person_Position (text, value, description) values ('HFDR', 20000003, 'Head First-Decubitus Right');
insert into Radiology_Person_Position (text, value, description) values ('HFDL', 20000004, 'Head First-Decubitus Left');
insert into Radiology_Person_Position (text, value, description) values ('FFDR', 20000005, 'Feet First-Decubitus Right');
insert into Radiology_Person_Position (text, value, description) values ('FFDL', 20000006, 'Feet First-Decubitus Left');
insert into Radiology_Person_Position (text, value, description) values ('FFP', 20000007, 'Feet First-Prone');
insert into Radiology_Person_Position (text, value, description) values ('FFS', 20000008, 'Feet First-Supine');
insert into Radiology_Person_Position (text, value, description) values ('LFP', 20000009, 'Left First-Prone');
insert into Radiology_Person_Position (text, value, description) values ('LFS', 20000010, 'Left First-Supine');
insert into Radiology_Person_Position (text, value, description) values ('RFP', 20000011, 'Right First-Prone');
insert into Radiology_Person_Position (text, value, description) values ('RFS', 20000012, 'Right First-Supine');
insert into Radiology_Person_Position (text, value, description) values ('AFDR', 20000013, 'Anterior First-Decubitus Right');
insert into Radiology_Person_Position (text, value, description) values ('AFDL', 20000014, 'Anterior First-Decubitus Left');
insert into Radiology_Person_Position (text, value, description) values ('PFDR', 20000015, 'Posterior First-Decubitus Right');
insert into Radiology_Person_Position (text, value, description) values ('PFDL', 20000016, 'Posterior First-Decubitus Left');
insert into Radiology_Person_Position (text, value, description) values ('AP', 20000017, 'Anterior/Posterior');
insert into Radiology_Person_Position (text, value, description) values ('PA', 20000018, 'Posterior/Anterior');
insert into Radiology_Person_Position (text, value, description) values ('LL', 20000019, 'Left Lateral');
insert into Radiology_Person_Position (text, value, description) values ('RL', 20000020, 'Right Lateral');
insert into Radiology_Person_Position (text, value, description) values ('RLD', 20000021, 'Right Lateral Decubitus');
insert into Radiology_Person_Position (text, value, description) values ('LLD', 20000022, 'Left Lateral Decubitus');
insert into Radiology_Person_Position (text, value, description) values ('RLO', 20000023, 'Right Lateral Oblique');
insert into Radiology_Person_Position (text, value, description) values ('LLO', 20000024, 'Left Lateral Oblique');


create table Radiology_Dose_Units (
  text          		varchar(50),
  value					integer,
  description	varchar(100)
);

insert into Radiology_Dose_Units (text, value, description) values ('NONE', 30000000, 'Empty unit');
insert into Radiology_Dose_Units (text, value, description) values ('kVp', 30000001, 'Kilovolt Peak');
insert into Radiology_Dose_Units (text, value, description) values ('T', 30000002, 'tesla');

create table Radiology_Exposure_Units (
  text          		varchar(50),
  value					integer,
  description	varchar(100)
);

insert into Radiology_Exposure_Units (text, value, description) values ('NONE', 40000000, 'Empty unit');
insert into Radiology_Exposure_Units (text, value, description) values ('msec', 40000001, 'Duration of X-Ray exposure');

create table Radiology_device(
 text varchar(50),
 value varchar(50)

);

insert into Radiology_device(text, value) values('HOST-10471',50000000);
insert into Radiology_device(text, value) values('Optima660',50000001);
insert into Radiology_device(text, value) values('PHILIPS-18976F9',50000002);
insert into Radiology_device(text, value) values('HOST-100057',50000003);

create table Radiology_modality (
  text          	varchar(50),
  value				integer
);

insert into Radiology_modality (text, value) values ('CR', 60000001);
insert into Radiology_modality (text, value) values ('DX', 60000002);
insert into Radiology_modality (text, value) values ('CT', 60000003);
insert into Radiology_modality (text, value) values ('MR', 60000004);
insert into Radiology_modality (text, value) values ('NM', 60000005);
insert into Radiology_modality (text, value) values ('OT', 60000006);
insert into Radiology_modality (text, value) values ('PETCT', 60000007);

create table Radiology_protocol (
  text          		varchar(50),
  value				integer
);

insert into Radiology_protocol (text, value) values ('I_A-P EN/ABDiDOSE', 70000000);
insert into Radiology_protocol (text, value) values ('6.1 Enhace Abdomen-Pelvis CT',70000001);
insert into Radiology_protocol (text, value) values ('NON A-P(SONG)/ABDiDOSE', 70000002);
insert into Radiology_protocol (text, value) values ('eTHRIVE AX SENSE', 70000003);
insert into Radiology_protocol (text, value) values ('Enhance Abdomen/ABD', 70000004);

create table Radiology_units (
  text          		varchar(50),
  value					integer,
  description			varchar(100)
);

insert into Radiology_units (text, value, description) values ('NONE', 80000000, 'Empty unit');
insert into Radiology_units (text, value, description) values ('kVp', 80000001, 'Kilovolt Peak');
insert into Radiology_units (text, value, description) values ('T', 80000002, 'tesla');
insert into Radiology_units (text, value, description) values ('msec', 80000003, 'msec');


create table Radiology_condition (
  text          	varchar(50),
  value				integer
);

insert into Radiology_condition (text, value) values ('Urinary tract stone', 90000000);
insert into Radiology_condition (text, value) values ('Sarcopenia', 90000001);
insert into Radiology_condition (text, value) values ('Alcoholic fatty liver', 90000002);
insert into Radiology_condition (text, value) values ('Non-alcoholic fatty liver', 90000003);

create table Radiology_occurrence (
  radiology_occurrence_ID          		integer not null primary key,
  radiology_occurrence_date        		date not null,
  radiology_occurrence_datetime			time,
  Person_ID        						integer not null,
  Condition_occurrence_id				integer,
  Device_concept_id						integer,
  
  radiology_modality_concept_ID			integer not null,
  Person_orientation_concept_id			integer,
  radiology_protocol_concept_id			integer,
  Image_total_count						integer not null,
  Image_type							varchar(50),
  Anatomic_site_concept_id				integer,
  radiology_Comment						varchar(1000),
  Image_dosage_unit_concept_id			integer,
  Dosage_value_as_number				integer not null,
  Image_exposure_time_unit_concept_id	integer,
  Image_exposure_time					real,
  Radiology_dirpath						varchar(800),
  Visit_occurrence_id					integer
);

create table Radiology_image (
  Image_ID          					integer not null primary key,
  Radiology_occurrence_ID        		integer not null,
  Person_ID								integer	not null,
  Person_orientation_concept_id			integer not null,
  Image_phase_concept_id				integer,
  Image_no								integer not null,
  Phase_total_no						integer not null,
  image_resolution_Rows					integer not null,
  image_Resolution_Columns				integer not null,
  Image_Window_Level_Center				varchar(50),
  Image_Window_Level_Width				varchar(50),
  Image_slice_thickness					integer,
  image_filepath						varchar(500) not null
);
