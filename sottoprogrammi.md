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

#### Esempio : calcolo del perimetro del triangolo, WPF

    C#
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPerimetro_Click(){
            InsDati();

        }
    }
