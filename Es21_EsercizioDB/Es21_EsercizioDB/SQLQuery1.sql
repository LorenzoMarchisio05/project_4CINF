-- Aggiungere il campo CLIL (si/no) di default a 0,
-- aggiornare tutti i record impostando il valore false
-- aggiornarlo a true per SIS
alter table MATERIE
add clil bit default(0);

update MATERIE 
set clil = 1 
where IdMateria = 'sis';

--tutti i dati ordinati per materia decrescente
select *
from MATERIE
order by Materia desc;

-- il numero di materie ed il numero ore delle materie con compresenza
select count(*) as materia, NumeroOre
from MATERIE
where Compresenza = 1 and NumeroOre is not null
group by NumeroOre;

-- le materie con più di 3 ore senza compresenza
select * 
from MATERIE
where NumeroOre > 3 and Compresenza = 0;

-- le materie che contengono la stringa INFORM
select Materia
from MATERIE
where Materia like '%inform%';

-- idMateria di cui non si sa il numeroOre
select idMateria 
from MATERIE
where NumeroOre is null;

-- Gli alunni nati nel mese attuale

-- Gli alunni che compiono gli anni oggi

-- Per ogni mese/anno iI numero di alunni

-- Per ogni città il numero di alunni escludendo le citta con un solo alunno, in ordine decrescente rispetto al numero alunni.
select count(*) as 'alunni', citta
from ALUNNI
where alunni <> 1
group by citta;

-- La media delle altezze escludendo gli alunni di Fossano e Bra
select AVG(Altezza)
from ALUNNI
where citta <> 'fossano' and citta <> 'bra'
