update ALUNNI
set altezza = altezza + 1
where citta = 'savigliano';

-- visualizza cognome nome alunno voto più alto

select top 1 with ties 
ALUNNI.nome + ' ' + ALUNNI.cognome, ALUNNI.voto
from ALUNNI, VOTI
where ALUNNI.idAlunno = VOTI.idAlunno
order by VOTi.voto desc;

select ALUNNI.nome + ' ' + ALUNNI.cognome, VOTI.voto
from ALUNNI, VOTI
where ALUNNI.idAlunno = VOTI.idAlunno
	and VOTI.voto = (select max(voto) from VOTI);

select ALUNNI.nome + ' ' + ALUNNI.cognome, AVG(VOTI.voto) as media
from ALUNNI, VOTI
where ALUNNI.idAlunno = VOTI.idAlunno
group by ALUNNI.nome, ALUNNI.cognome;