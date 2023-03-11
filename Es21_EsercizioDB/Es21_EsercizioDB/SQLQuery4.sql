--Query sulla tabella ASSENZE
--1. visualizzare tutti i dati delle assenze di oggi

select *
from ASSENZE
where dataAssenza = CONVERT(date, getdate(), 103);


--2. visualizzare le assenze in un certo periodo: 31/01/2023 e oggi

select *
from ASSENZE
where dataAssenza between '2023-01-31' and Convert(char(10), GETDATE(), 101);


--3. visualizzare le assenze in un certo periodo: 31/01/2023 e 28/02/2023

select *
from ASSENZE
where dataAssenza between '2023-01-31' and '2023-02-28';


--4. visualizzare i giorni di assenza di un alunno di cui si conosce ID

select count(ASSENZE.dataAssenza) as 'numero assenze'
from ALUNNI, ASSENZE
where ALUNNI.idAlunno = ASSENZE.idAlunno and ASSENZE.idAlunno = 12;


--5. visualizzare la data, il tipo e id alunni delle assenze non giustificate

select dataAssenza, tipo, idAlunno
from ASSENZE
where giustificata = 0;


--6. visualizzare per ogni alunno e tipo di assenza il numero di assenze

select ALUNNI.idAlunno, (ALUNNI.nome + ' ' + ALUNNI.cognome) as 'nome completo', ASSENZE.tipo
from ALUNNI, ASSENZE
where ALUNNI.idAlunno = ASSENZE.idAlunno
group by ALUNNI.nome, ALUNNI.cognome, ASSENZE.tipo;


--7. visualizzare gli alunni senza assenze

select distinct ALUNNI.*
from ALUNNI, ASSENZE
where ALUNNI.idAlunno != ASSENZE.idAlunno;

select *
from ALUNNI
where idAlunno not in (
	select distinct idAlunno
	from ASSENZE
)


--8. visualizzare per ogni idAlunno, cognome, nome il numero di giorni di assenza, numero U e numero E
select ALUNNI.idAlunno, ALUNNI.cognome, ALUNNI.nome, ASSENZE.tipo count(*) as 'numero assenze'
from ALUNNI, ASSENZE
where ALUNNI.idAlunno = ASSENZE.idAlunno
group by ALUNNI.idAlunno, ALUNNI.cognome, ALUNNI.nome;
