Pastebejau kad reikia skaiciuoti ne vidurki(matematini), o galutini vidurki tik 4 laboratoriniame darbe.
Program.cs faile esantys benchmark rezultatai, skaicius prie ju reiskia kiek generuota:
  1 - 10
  2 - 100
  3 - 1000
  4 - 10000
  5 - 100000

      Sort and Write using List:
                1: 00:00:00.0079784
                2: 00:00:00.0049863
                3: 00:00:00.0079793
                4: 00:00:00.0339095
                5: 00:00:00.3670187
      Sort and Write using LinkedList:
                1: 00:00:00.0049866
                2: 00:00:00.0029875
                3: 00:00:00.0079783
                4: 00:00:00.0329085
                5: 00:00:00.3630080
      Sort and Write using Deque:
                1: 00:00:00.0049869
                2: 00:00:00.0039890
                3: 00:00:00.0089765
                4: 00:00:00.0329398
                5: 00:00:00.3630294

  Po keliu bandymu su kiekvienu is siu pastebejau, kad jokio didelio skirtumo tarp siu konteineriu nera.

  Paskutinej final versijai pasirinkau 2 metoda ir gavau tokius rezultatus:
  1: 00:00:00.0049866
  2: 00:00:00.0039893
  3: 00:00:00.0079786
  4: 00:00:00.0249617
  5: 00:00:00.2722992

  Master branch yra versija v0.1
  tada branch 2 v0.2 ir t.t.
  Versija v1.0 yra branch Final.

.
