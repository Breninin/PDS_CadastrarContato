# Breno Alcides Paio de Medeiros | 3°B informática
create database app_contato_bd_breno;
use app_contato_bd_breno;

select * from contato;
#delete from contato where (con_nome = "Teste");

create table contato 
(
	con_id int not null auto_increment primary key,
    con_nome varchar(100) not null,
    con_data_nasc date,
    con_sexo varchar(30) not null,
    con_email varchar(100) not null,
    con_telefone varchar(100) not null
);

insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (1, 'Devin Adderson', '2004-12-15', 'Masculino', 'dadderson0@bigcartel.com', '1534786324');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (2, 'Roxanne Bigham', '2004-04-06', 'Feminino', 'rbigham1@chronoengine.com', '5882951932');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (3, 'Hayley Pummery', '2005-11-02', 'Feminino', 'hpummery2@simplemachines.org', '6593314878');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (4, 'Ethelda Larcier', '2005-01-01', 'Feminino', 'elarcier3@wisc.edu', '2843702232');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (5, 'Constancia Dunlea', '2004-03-20', 'Feminino', 'cdunlea4@yolasite.com', '3655212257');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (6, 'Rafaelita Braun', '2004-12-30', 'Feminino', 'rbraun5@cbsnews.com', '3643426164');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (7, 'Orelle Everix', '2005-02-14', 'Feminino', 'oeverix6@opensource.org', '2099557541');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (8, 'Sal MacAiline', '2004-04-15', 'Feminino', 'smacailine7@rambler.ru', '6955429309');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (9, 'Anthony Wicklen', '2004-07-08', 'Masculino', 'awicklen8@berkeley.edu', '7631941055');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (10, 'Selinda Caulcott', '2004-10-08', 'Feminino', 'scaulcott9@livejournal.com', '9316441795');