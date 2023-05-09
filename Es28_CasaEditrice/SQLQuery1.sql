
select ABBONATI.Cognome + ' ' + ABBONATI.Nome
from ABBONATI, PUBBLICAZIONI, ABBONAMENTI
where PUBBLICAZIONI.IdPubblicazione = ABBONAMENTI.IdPubblicazione 
and ABBONAMENTI.IdAbbonato = ABBONATI.IdAbbonato
and PUBBLICAZIONI.Titolo = 'airone'
and ABBONAMENTI.TipoAbbonamento = 'A';

select count(*) as numero_riviste
from ABBONATI, ABBONAMENTI, PUBBLICAZIONI
where PUBBLICAZIONI.IdPubblicazione = ABBONAMENTI.IdPubblicazione 
and ABBONAMENTI.IdAbbonato = ABBONATI.IdAbbonato
and ABBONATI.Cognome = 'boccaccio'
and ABBONATI.Nome = 'giovanni'
and PUBBLICAZIONI.GR = 'R';

select PUBBLICAZIONI.IdPubblicazione, PUBBLICAZIONI.Titolo, count(*) as numero_abbonati
from PUBBLICAZIONI, ABBONAMENTI
where PUBBLICAZIONI.IdPubblicazione = ABBONAMENTI.IdAbbonamento
group by PUBBLICAZIONI.IdPubblicazione, PUBBLICAZIONI.Titolo;

select PUBBLICAZIONI.IdPubblicazione, PUBBLICAZIONI.Titolo
from PUBBLICAZIONI, ABBONAMENTI
where PUBBLICAZIONI.IdPubblicazione = ABBONAMENTI.IdPubblicazione
and PUBBLICAZIONI.GR = 'G'
and ABBONAMENTI.TipoAbbonamento = 'A'
group by PUBBLICAZIONI.IdPubblicazione, PUBBLICAZIONI.Titolo
having count(*) > 1;

select ABBONATI.IdAbbonato, (ABBONATI.Cognome + ' ' + ABBONATI.Nome) as nominativo
from PUBBLICAZIONI, ABBONAMENTI, ABBONATI
where PUBBLICAZIONI.IdPubblicazione = ABBONAMENTI.IdPubblicazione 
and ABBONAMENTI.IdAbbonato = ABBONATI.IdAbbonato
and PUBBLICAZIONI.Titolo = 'Airone'
and ABBONATI.IdAbbonato in (select ABBONATI.IdAbbonato
							from PUBBLICAZIONI, ABBONAMENTI, ABBONATI
							where PUBBLICAZIONI.IdPubblicazione = ABBONAMENTI.IdPubblicazione 
							and ABBONAMENTI.IdAbbonato = ABBONATI.IdAbbonato
							and PUBBLICAZIONI.Titolo = 'Braidese');

-- visualizza riviste senza abbonati

select PUBBLICAZIONI.IdPubblicazione, PUBBLICAZIONI.Titolo
from PUBBLICAZIONI
where PUBBLICAZIONI.GR = 'R'
and PUBBLICAZIONI.IdPubblicazione not in (select distinct IdPubblicazione
										  from ABBONAMENTI);
