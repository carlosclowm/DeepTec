create database Trasplante_de_organos;
use Trasplante_de_organos;

create table usuarios(
id_usuario int,
usuario varchar(30),
contraseña varchar(30),
rango int,
primary key(id_usuario)
);

insert into usuarios values(
1,
'admin',
'admin',
1);

create table Donador (
id_donador varchar(20),
nombre_donador varchar(30),
apa_donador varchar(30),
ama_donador varchar(30),
tipo_sangre_donador varchar(3),
edad_donador int,
apto bit,
desc_apto text,
consentimiento text,
sexo_donador varchar(30),
estatus_vida bit,
telefono_donador float,
pais_donador varchar(30),
estado_donador varchar(30),
region_donador varchar(30),
ciudad_donador varchar(30),
direccion varchar(100),
primary key (id_donador)
);

select * from Donador;

insert into Donador values(
'Donador_1',
'Kevin Leonel',
'Abundis',
'Morales',
'A+',
20,
1,
'La persona no ha sufrido de hepatitis, no sufre de enfermedades cardiovasculares, no tiene tatuajes, no sufre de presion, no fuma',
'La persona dio el consentimiento de que si donara',
'Masculino',
1,
'7442364708',
'Mexico',
'Guerrero',
'Acapulco',
'Coloso',
'Etapa 8, Edificio 1, Departamento 301'
);

insert into Donador values(
'Donador_2',
'Jorgeluis Samuel',
'Delgado',
'Sabido',
'O-',
21,
0,
'La persona ha sufrido de hepatitis, no sufre de enfermedades cardiovasculares, tiene tatuajes, no sufre de presion, etc',
'La persona dio el consentimiento de que si donara',
'Masculino',
1,
'7445056879',
'Mexico',
'Guerrero',
'Costa Chica',
'La esperanza',
'Etapa 20, Edificio 3, Departamento 102'
);

insert into Donador values(
'Donador_3',
'Jesus Erasmo',
'Gallardo',
'Cabrera',
'AB+',
20,
1,
'La persona no ha sufrido de hepatitis, no sufre de enfermedades cardiovasculares, no tiene tatuajes, no sufre de presion, etc',
'La persona dio el consentimiento de que si donara',
'Masculino',
1,
'7443454647',
'Mexico',
'Guerrero',
'Tierra Caliente',
'Progreso',
'Av. peña blanca, casa numero 2, fraccionamiento las palmas'
);

create table Receptor (
id_receptor varchar(20),
nombre_receptor varchar(30),
apa_receptor varchar(30),
ama_receptor varchar(30),
tipo_sangre_receptor varchar(3),
edad_receptor int,
sexo_receptor varchar(30),
pago bit,
cantidad_pago float,
nombre_responsable varchar(100),
tiempo_espera varchar (50),
telefono_receptor float,
pais_receptor varchar(30),
estado_receptor varchar(30),
region_receptor varchar(30),
ciudad_receptor varchar(30),
direccion varchar(100),
primary key (id_receptor)
);

select * from Receptor;

insert into Receptor values(
'Receptor_1',
'Carlos',
'Serrano',
'Bello',
'AB+',
22,
'Masculino',
1,
1000000,
'Su mama',
'5 dias, 4 horas, 26 minutos',
'7445678987',
'Mexico',
'Nuevo Leon',
'Norte',
'Monterrey',
'Avenida principal, colonia san marcos, casa numero 102'
);

insert into Receptor values(
'Receptor_2',
'Dilan',
'Jimenez',
'Hernandez',
'AB-',
21,
'Masculino',
0,
0,
'Su papa',
'6 dias, 20 horas, 38 minutos',
'7442789865',
'Mexico',
'Nuevo Leon',
'Sur',
'Monterrey',
'Avenida el bosque, colonia nuevo laredo, casa numero 340'
);


create table Doctor(
cedula_doctor int,
nombre_doctor varchar(30),
apa_doctor varchar(30),
ama_doctor varchar(30),
primary key (cedula_doctor)
);

select * from Doctor;

insert into Doctor values(
908990,
'Angel Sahid',
'Castrejon',
'Mendoza'
);

insert into Doctor values(
908991,
'Clarisa',
'Tolentino',
'Bracamontes'
);


create table Organos(
id_organo varchar(20),
nombre_organo varchar(30),
peso float,
fecha_extraccion date,
id_donador varchar(20),
primary key (id_organo),
foreign key (id_donador) references Donador(id_donador)
);


select * from Organos;

insert into Organos values(
'Riñon_1',
'Riñon',
2.4,
'2018-09-12',
'Donador_3'

);

insert into Organos values(
'Pulmon_1',
'Pulmon',
2.0,
'2018-08-31',
'Donador_3'

);

insert into Organos values(
'Higado_1',
'Higado',
1.7,
'2018-09-03',
'Donador_3'

);

insert into Organos values(
'Riñon_2',
'Riñon',
2.2,
'2018-09-10',
'Donador_1'

);

insert into Organos values(
'Riñon_3',
'Riñon',
2.5,
'2018-09-18',
'Donador_2'

);

insert into Organos values(
'MedulaOsea_1',
'Medula Osea',
0.3,
'2018-09-03',
'Donador_3'

);

insert into Organos values(
'Cornea_1',
'Cornea',
0.10,
'2018-09-10',
'Donador_1'

);


create table Trasplante(
clave_trasplante varchar(20),
id_organo varchar(20),
id_donador varchar(20),
id_receptor varchar(20),
cedula_doctor int,
fecha_cirugia date,
estatus_cirugia bit,
primary key (clave_trasplante),
foreign key (id_organo) references Organos(id_organo),
foreign key (id_donador) references Donador(id_donador),
foreign key (id_receptor) references Receptor(id_receptor),
foreign key (cedula_doctor) references Doctor(cedula_doctor)
);

select * from Trasplante;

insert into Trasplante values(
'Trasplante_1',
'Riñon_1',
'Donador_3',
'Receptor_2',
908991,
'2018-09-14',
1
);

insert into Trasplante values(
'Trasplante_2',
'Riñon_2',
'Donador_1',
'Receptor_1',
908990,
'2018-09-12',
1
);

insert into Trasplante values(
'Trasplante_3',
'Pulmon_1',
'Donador_3',
'Receptor_2',
908991,
'2018-09-02',
0
);



select * from Trasplante;
select * from Organos;
select * from Donador;
select * from Receptor;
select * from Doctor;

donadordonadordonadordonador
select id_donador , nombre_organo 
from Organos
where id_donador = 'Donador_1' ;

select Donador.nombre_donador, Receptor.nombre_receptor 
from Donador, Receptor
where Donador.pais_donador = Receptor.pais_receptor;

select nombre_receptor , apa_receptor , ama_receptor
from Receptor
where cantidad_pago > 1000 ;

select nombre_receptor , apa_receptor , ama_receptor
from Receptor
where cantidad_pago >= 0 ;

select  Donador.nombre_donador, fecha_extraccion, Organos.nombre_organo 
from Organos, Donador
where fecha_extraccion between '2017-09-09' and '2018-09-09' and Donador.id_donador = Organos.id_donador;


Select Doctor.nombre_doctor, Organos.nombre_organo, Donador.nombre_donador, Receptor.nombre_receptor,Organos.fecha_extraccion, Trasplante.fecha_cirugia
from Doctor, Trasplante, Donador, Receptor, Organos
where Trasplante.cedula_doctor = Doctor.cedula_doctor and Trasplante.id_organo = Organos.id_organo and 
Trasplante.id_donador = Donador.id_donador and Trasplante.id_receptor = Receptor.id_receptor and 
Donador.id_donador = 'Donador_3';

select nombre_donador, desc_apto, edad_donador, tipo_sangre_donador, nombre_receptor, tipo_sangre_receptor
from Donador, Receptor
where id_donador = 'Donador_2'

update Donador 
set id_donador = 'Donador_1' 
where id_donador = 1;

delete from Organos 
where fecha_extraccion between '2018-09-01' and '2018-10-01';

alter table Doctor add Esp_Doctor varchar(25);
update Doctor
set Esp_Doctor = 'Neurocirujano'
where cedula_doctor = 908991;

select * from doctor;
select * from Trasplante;

select * from Trasplante;
select * from Organos;
select * from Donador;
select * from Receptor;
select * from Doctor;

create view Donadores
as select id_donador, nombre_donador, apa_donador , ama_donador
from dbo.Donador
where id_donador = 'Donador_1';

select * from Donadores;

create view Trasplantes_del_mes
as select nombre_donador, nombre_receptor, nombre_doctor, nombre_organo, fecha_cirugia
from Donador, Receptor , Organos , Doctor , Trasplante
where  Trasplante.id_donador = Donador.id_donador and
Trasplante.cedula_doctor = Doctor.cedula_doctor and
Trasplante.id_organo = Organos.id_organo and
Trasplante.id_receptor = Receptor.id_receptor
and fecha_cirugia between '2018-09-01' and '2018-09-21';

select * from Trasplantes_del_mes;

drop view Trasplantes_del_mes

select * from donador where id_donador='Donador_2';