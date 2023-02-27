select top 3 with ties * 
from ALUNNI
order by altezza desc;
-- visualizza statura media oppure alta in base altezza

select idAlunno, cognome, nome,
iif(altezza > 190, 'alta', 'media')
from ALUNNI;


select idAlunno, cognome, nome,
iif(altezza < 175, 'bassa', iif(altezza > 175 and altezza < 189, 'media', 'alta'))
from ALUNNI;

select * from ALUNNI;

-- visualizzare se è maggiorenne o minorenne
select *,
iif(
	datediff(YEAR, dataNascita, getdate()) > 18, 
	'maggiorenne', 
	iif( month(getdate()) = month(dataNascita), 
		'quasi maggiorenne', 
		iif(dataNascita is null, 
			'?', 
			'minorenne')))
from ALUNNI