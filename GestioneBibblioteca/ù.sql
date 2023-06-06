select Libri.*
from Libri, Scrivono, Autori
where Libri.IdLibro = Scrivono.IdLibro
and Scrivono.IdAutore = Autori.IdAutore
and Autori.Cognome = 'Tribunella' and Autori.Nome = 'Simone';

select Libri.IdLibro, Libri.Titolo, (Soci.Cognome + ' ' + Soci.Nome ) as Nominativo
from Libri, Prestiti, Soci
where Libri.IdLibro = Prestiti.IdLibro
and Prestiti.IdSocio = Soci.IdSocio
and Prestiti.DataFine is null
and Soci.Cognome = 'Abrate';

select Autori.IdAutore, (Autori.Cognome + ' ' + Autori.Nome) as Nominativo, count(*) as 'Numero Libri'
from Autori, Scrivono
where Autori.IdAutore = Scrivono.IdAutore 
group by Autori.IdAutore, Autori.Cognome, Autori.Nome
having count(*) >= 2
order by Autori.Cognome + ' ' + Autori.Nome;

