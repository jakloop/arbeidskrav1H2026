# Arbeidskrav 1, HØST 2026, Backend Programmering
- Student: Jakob Sørli
- Date: 04 - 25th September


## Table of contents
 - Introduction
 - Analyse (oppgave 1)




### Analyse Task 1

Tidskompleksitet i algoritmene
Lineært søk og binært søk er to veldig ulike måter å søke i et array. Linære søk søker sekvensielt 
gjennom elementene. Hvert eneste element sammenlignes med måleverdien. Algorimen stopper ved første treff
eller når har gått gjennom hele samlingen (Gokstad Akademiet, Økt1 uke 34). Det betyr at i beste fall
så blir den ferdig veldig fort, ved f.eks, tom liste, kort liste eller at den treffer verdien tidlig i listen.
I verste fall så går den gjennom en veldig lang liste og bruker lang tid. 

I binærsøk er vi avhengige av at arrayet er sortert. Dette er fordi den hele tiden prøver å peile seg 
inn på verdien basert på de grenseverdiene man har satt. Dersom dataene ikke er sorterte vil denne peilingen 
bli helt feil og man kan ikke gjennomføre et gyldig søk fordi data som kanskje skulle vært søkt blir valgt bort. 
Om man for eksempel søker etter 
I binærsøk så sammenligner man alltid den midterste verdien med "target". Hvis målverdien er større eller mindre
forkaster man den delen hvor måleverdien umulig kan være. Dersom man treffer måleverdien med "mid", lagrer man treffet
og fortsetter søket mot venstre, forutsett at arrayet er sortert i stigende rekkefølge mot høyre. På den måten
får finner man den laveste indexen av verdien. 

-- antall sammenligninger
--- hva telles som en sammenligning
Når man leter etter en verdi i et array og skal vurdere om 
-- big(O)
--- beste og verste scenario

-- Hvorfor binærsøk krever sorterete data
--- Kostnad på å sortere data vs. kost


