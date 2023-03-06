select ALUNNI.* 
from ALUNNI, ASSENZE
where ASSENZE.idAlunno = ALUNNI.idAlunno;

select ALUNNI.*
from ALUNNI, ASSENZE
where (ASSENZE.idAlunno = ALUNNI.idAlunno) and (ASSENZE.dataAssenza = CONVERT(DATE, GETDATE()));

select *
from ASSENZE
where dataAssenza >= CONVERT(DATE, '15/01/2023', 103) and dataAssenza <= CONVERT(DATE, GETDATE());