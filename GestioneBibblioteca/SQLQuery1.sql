select Soci.IdSocio, Soci.Cognome, Soci.Nome, COUNT(Prestiti.IdLibro) as 'Numero Libri'
from Soci left join Prestiti
on Soci.IdSocio = Prestiti.IdSocio
group by Soci.IdSocio, Soci.Cognome, Soci.Nome;

select Soci.IdSocio, Soci.Cognome, Soci.Nome, Libri.Titolo
from Soci 
	join Prestiti on (Soci.IdSocio = Prestiti.IdSocio)
	join Libri on (Prestiti.IdLibro = Libri.IdLibro);

select Generi.IdGenere, Generi.Genere, Libri.Titolo
from Generi
	left join Libri on (Generi.IdGenere = Libri.IdGenere);

select Libri.Titolo, ParoleChiave.ParolaChiave
from Libri, SonoContenute, ParoleChiave
where Libri.IdLibro = SonoContenute.IdLibro
	and SonoContenute.IdParolaChiave = ParoleChiave.IdParolaChiave;

select top 1 with ties Soci.IdSocio, (Soci.Cognome + ' ' + Soci.Nome) as 'Nominativo', COUNT(Prestiti.IdLibro) as 'Numero Libri'
from Soci 
	left join Prestiti on Soci.IdSocio = Prestiti.IdSocio
group by Soci.IdSocio, Soci.Cognome, Soci.Nome
order by Count(Prestiti.IdLibro) desc;