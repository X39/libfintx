using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.FinTs3_0
{
    public enum ESepaOp
    {
        ///<summary>
        ///    Nicht Spezifiziert
        ///    SEPA Kontoverbindungen anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSPA,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Einzelüberweisung einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCCS,
        ///<summary>
        ///    Überweisungen
        ///    Terminierte SEPA-Überweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSE,
        ///<summary>
        ///    Überweisungen
        ///    Terminierte SEPA-Überweisung ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSA,
        ///<summary>
        ///    Überweisungen
        ///    Bestand terminierter SEPA-Überweisungen anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSB,
        ///<summary>
        ///    Überweisungen
        ///    Löschung terminierte SEPA-Überweisungen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSL,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Dauerauftrag einrichten
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDE,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Dauerauftragsänderung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDN,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Dauerauftragsaussetzung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDU,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Dauerauftragsbestand anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDB,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Dauerauftragsänderungsvormerkungen anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDA,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Dauerauftragslöschung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDL,
        ///<summary>
        ///    Überweisungen
        ///    Vorbereitete SEPA-Überweisung anlegen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCVE,
        ///<summary>
        ///    Überweisungen
        ///    Vorbereitete SEPA-Überweisung ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCVA,
        ///<summary>
        ///    Überweisungen
        ///    Bestand vorbereitete SEPA-Überweisung anzeigen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCVB,
        ///<summary>
        ///    Überweisungen
        ///    Vorbereitete SEPA-Überweisung löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCVL,
        ///<summary>
        ///    Überweisungen
        ///    EURO-Expresszahlungen online übertragen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKEUE,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Instant Payment Zahlung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKIPZ,
        ///<summary>
        ///    Überweisungen
        ///    SEPA-Instant Payment Status anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKIPS,
        ///<summary>
        ///    Sammelüberweisungen
        ///    SEPA-Sammelüberweisung einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCCM,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Einreichung terminierter SEPA-Sammelüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCME,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Bestand terminierter SEPA-Sammelüberweisungen abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCMB,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Löschung terminierter SEPA-Sammelüberweisungen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCML,
        ///<summary>
        ///    Sammelüberweisungen
        ///    SEPA Einzellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDS,
        ///<summary>
        ///    Sammelüberweisungen
        ///    SEPA-Lastschriftwiderspruch
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSW,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Bestand rückgabefähiger SEPA-Lastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSB,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Einreichung terminierter SEPA-Einzellastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSE,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Änderung terminierter SEPA-Einzellastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSA,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Bestand terminierter SEPA-Einzellastschriften abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDBS,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Terminierte SEPA-Einzellastschriften löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSL,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Einreichung terminierter SEPA-Firmeneinzellastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBSE,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Änderung terminierter SEPA-Firmeneinzellastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBSA,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Bestand terminierter SEPA-Firmeneinzellastschriften abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBBS,
        ///<summary>
        ///    Sammelüberweisungen
        ///    Terminierte SEPA-Firmeneinzellastschriften löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBSL,
        ///<summary>
        ///    Sammellastschriften
        ///    Terminierte SEPA Sammellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDME,
        ///<summary>
        ///    Sammellastschriften
        ///    Terminierte SEPA Firmensammellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBME,
        ///<summary>
        ///    Sammellastschriften
        ///    Bestand terminierter SEPA-Sammellastschriften abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDMB,
        ///<summary>
        ///    Sammellastschriften
        ///    Löschung terminierter SEPA-Sammellastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDML,
        ///<summary>
        ///    Sammellastschriften
        ///    Bestand terminierter SEPA Firmensammellastschriften anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBMB,
        ///<summary>
        ///    Sammellastschriften
        ///    Terminierte SEPA Firmensammellastschrift löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBML,
        ///<summary>
        ///    Sammellastschriften
        ///    SEPA Sammellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDM,
        ///<summary>
        ///    Postfach
        ///    Postfach Nachrichtenliste anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKPOF,
        ///<summary>
        ///    Postfach
        ///    Postfach Nachrichten anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKKAA,
    }
}
