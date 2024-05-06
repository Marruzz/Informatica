# Cosa sono i sottoprogrammi

## Lezione 1 - Introduzione all'uso dei sottoprogrammi

#### Definizione di Sottoprogramma

> Un sottoprogramma è un codice sorgente richiamato da un programma informatico principale per risolvere un determinato problema specifico e ricorrente.

Vengono anche chiamati **_funzioni_** o **metodi**.<br>Sottoprogramma è il termine più generale. <br>Si chiamano **funzioni** nel linguaggio **C** e **_metodi_** nei linguaggi **OOP** _(Object Oriented Project)_. Si chiamano anche procedure nei linguaggi più vecchi.

Non si usano più programmi **monolitici**, ma si usano programmi **_modulari_**. Si divide il codice in moduli che abbiano senso, ossia che ogni modulo abbia una funzione, e poi si usano i moduli.

> Un sottoprogramma è lo stumento che il linguaggio di programmazione dà a disposizione per creare i moduli.
> Si tratta di un **_insieme di istruzioni_** che svolgono una funzione specifica.

Se un sottoprogramma ha una funzione piuttosto comune, lo si può richiamare più volte. La programmazione ad oggetti è alla base della potenza dell'informatica moderna. Finché non esisteva la programmazione ad oggetti, non si raggiungevano le grandi vette che si raggiungono oggi.

L'utilizzo dei **framework**, per esempio, rappresenta l'utilizzo dei moduli di un sottoprogramma. I framework, detti anche _librerie_ sono dei moduli che si riutilizzano in modo da non dover riscrivere il codice.

Lo sviluppo moderno di videogiochi viene fatto attraverso i **_motori grafici_**. I motori grafici sono un'enorme _biblioteca_ di sottoprogrammi sviluppati con il **_paradigma_ di programmazione ad oggetti** (il modo in cui vengono sviluppati) e che si riutilizzano per non dover riscrivere il codice.
<br>

## Lezione 2 - Scomposizione dei problemi

La strategia principale è quella di **dividere** il problema in altri sottoproblemi più semplici.
_Dividi et impera_.

Ci sono due strade per risolvere un problema complesso, cioé:

- #### Top-down

  > Nel top-down, si parte dall'inizio del problema, **top**, e poi lo si inizia a suddividere in parti più piccole, **down**.
  > Si suddivide il problema in sottoproblemi più semplici, e si risolvono i sottoproblemi più semplici.

  > **_Si parte dal generale e si arriva ai piccoli problemi_**

- #### Bottom-up

  > Nel bottom-up, si parte da alcune piccole funzioni che so già svolgere e cimbinarle a costruire, **bottom**, e poi si suddividono in parti più grandi, **up**.

  > La si potrebbe utilizzare in fase di **_prototipo_**

La struttura dati che tiene traccia delle chiamate di un programma si chiama **stack**.
Se si supera il limite di chiamate in un programma si va in errore di annidamento, che prende il nome di _stack overflow_.

Il programma principale è detto **_chiamante_**, mentre i sottoprogrammi sono chiamati **_chiamate_**. Nei programmi monolitici non si ha né chiamante, né chiamate.

#### Vantaggi dei sottoprogrammi

- Più **ordinato**
- Più **semplice** da capire. I nomi che si danno alle funzioni devono essere esplicativi
- Principio di singola responsabilità - Il programma risolve un problema molto semplice. Secondo il **principio di singola responsabilità** il sottoprogramma può essere riutilizzato.

Per far avere dei dati ad un sottoprogramma bisogna passarglieli. Viene detto **_passaggio di parametri_**.

#### Ecco come si scrive una funzione

    tipo (restituito dalla funzione) nomeFunzione () {
        dichiarazione delle costanti;
        dichiarazione delle variabili;
        istruzioni;
        return valore;
    }

Il tipo della funzione può essere:

- int, string, double, bool, etc.
- void. Si scrive **void** se il modulo **_non restituisce_** alcun valore
  <br><br>

## Lezione 3 - Le variabili

Le variabili per essere utilizzate vanno dichiarate. In C# è obbligatorio dichiararle, in Python no, per esempio.

**Le variabili hanno una visibilità** (scope - mirino), che può essere:

- **_Globale_**
- **_Locale_**
  Si può dichiarare una variabile al di fuori di qualsiasi graffa, e si dice che la si dichiara a livello **globale**. Non è consigliato.

#### Variabili globali

> Le variabili globali sono quelle variabili chr hanno validità sia nel programma principale, sia nei sottoprogrammi, purché non siano ridichiarate

Se la variabile viene dichiarata in due spazi di visibilità diversi, si prende l'ultimo valore che assume la variabile. La variabile globale, invece, non la si può dichiarare in altri spazi. Se invece cambio il valore della variabile globale, il valore lo si cambia ovunque. <br>
Le variabili globali espongono varie problematiche contro l'hacking perché, se si cambia il valore da una parte, lo si cambis a ovunque.

#### Variabili locali

> Le variabili locali sono quelle che sono dichiarate all'interno dei singoli sottoprogrammi

Il metodo migliore è queloo di dichiarale il più vicino possibile al bisogno. Se serve in un if, la si dichiara lì, e se non basta, si sale solo di ul livello.

### I parametri

Ricordiamo come si scrive un sottoprogramma:

    tipo nomeFunzione () {
            dichiarazione delle costanti;
            dichiarazione delle variabili;
            istruzioni;
            return valore;
        }

Per far arrivare delle variabili ad un sottoprogramma, le si deve inserire all'interno delle parentesi. Qua sotto c'è un esempio

    float CalcoloArea(float altezza, float base){
        //queste due qua sono variabili locali
        float area;
        area = altezza * base;
        return area; //il valore di output
    }

    int main(int argc, char *argv[]){
        float altezza = float.Parse(Console.ReadLine());
        float base = float.Parse(Console.ReadLine());
        //stiamo passando i parametri alla  funzione
        float area = CalcoloArea(altezza, base);
        Console.WriteLine(area);
    }

Il passaggio dei prarametri tra il chiamante e il chiamato, per valore, è un meccanismo che prevede la copia del valore degli argomenti nei paramentri
