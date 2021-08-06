using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.FinTs3_0
{
    public enum EHbciOperation
    {
        ///<summary>
        ///    Detailansicht Bausparkonto (Sparkasse)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKBKD,
        ///<summary>
        ///    Kontenübersicht Bausparkonten
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKBKU,
        ///<summary>
        ///    Umsätze Bausparvertrag anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKBUM,
        ///<summary>
        ///    Deka-Fondssuche
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKDFS,
        ///<summary>
        ///    Liste Handelspartner (Makert Maker) anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKDIH,
        ///<summary>
        ///    Deka-Depot-Fondsaufstellung anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKFAF,
        ///<summary>
        ///    Abruf Kreditkartensalden
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKKKS,
        ///<summary>
        ///    Abruf von elektronischen Kontoauszügen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKKKA,
        ///<summary>
        ///    Abruf von elektronischen Kontoauszügen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKKAU,
        ///<summary>
        ///    Abruf Kreditkartenumsätze
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKKKU,
        ///<summary>
        ///    PIN online ändern (Geschäftsvorfall wird in 2016 von HKPAE abgelöst)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKPAE,
        ///<summary>
        ///    Neue Quote anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKQUT,
        ///<summary>
        ///    Quote annehmen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKQUO,
        ///<summary>
        ///    GuV-Analyse
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKWGV,
        ///<summary>
        ///    Liquiditätsvorschau
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKWLV,
        ///<summary>
        ///    Wertpapierorder
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKWOP,
        ///<summary>
        ///    Bestand der ZV Dateien abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKBAZ,
        ///<summary>
        ///    Freigabe ZV-Dateien
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKZDF,
        ///<summary>
        ///    Löschung ZV-Dateien
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        DKZDL,
        ///<summary>
        ///    FinTS Verbund-Finanzstatus Detailanzeige
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        GKVPD,
        ///<summary>
        ///    FinTS Verbund-Finanzstatus Übersicht
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        GKVPU,
        ///<summary>
        ///    Übermittlung eines öffentlichen Schlüssels
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HIISA,
        ///<summary>
        ///    Kreditinstitutsmeldung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HIKIM,
        ///<summary>
        ///    Statusprotokoll rückmelden
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HIPRO,
        ///<summary>
        ///    Statusprotokoll Parameter
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HIPROS,
        ///<summary>
        ///    Synchronisierungsantwort
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HISYN,
        ///<summary>
        ///    Alias (Anmeldename) anlegen / ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKANA,
        ///<summary>
        ///    Alias (Anmeldename) löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKANL,
        ///<summary>
        ///    EU-Überweisung oder Meldeteil
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKAOM,
        ///<summary>
        ///    Zahlungsauftrag im Außenwirtschaftsverkehr / Zahlungsauftrag im Außenwirtschaftsverkehr per Scheck
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKAUB,
        ///<summary>
        ///    Kartenanzeige
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKAZK,
        ///<summary>
        ///    Bestand terminierter SEPA-Firmeneinzellastschriften anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBBS,
        ///<summary>
        ///    Bestand terminierter SEPA-Firmensammellastschriften anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKBMB,
        ///<summary>
        ///    Kontoumsätze/neue Umsätze (camt)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCAN,
        ///<summary>
        ///    Kontoumsätze im Format camt anfordern / Zeitraum
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCAZ,
        ///<summary>
        ///    SEPA-Sammelüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCCM,
        ///<summary>
        ///    SEPA-Einzelüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCCS,
        ///<summary>
        ///    SEPA-Dauerauftragsänderungsvormerkungen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDA,
        ///<summary>
        ///    FinTS SEPA Dauerüberweisungen ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCDN,
        ///<summary>
        ///    Bestand der zugelassenen Empfängerkonten für SEPA-Umbuchungen anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCUB,
        ///<summary>
        ///    SEPA-Umbuchung auf Referenzkonto
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCUM,
        ///<summary>
        ///    term. SEPA-Überweisungen ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSA,
        ///<summary>
        ///    term. SEPA-Überweisungen abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSB,
        ///<summary>
        ///    term. SEPA-Überweisung Bestand abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCMB,
        ///<summary>
        ///    term. SEPA-Sammelüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCME,
        ///<summary>
        ///    term. SEPA-Überweisung Bestand löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCML,
        ///<summary>
        ///    term. SEPA-Überweisungen löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSL,
        ///<summary>
        ///    SEPA-Eilüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCSU,
        ///<summary>
        ///    Bestand vorbereiteter SEPA-Überweisungen abfragen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKCVB,
        ///<summary>
        ///    Dauerauftragsbestand holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDAB,
        ///<summary>
        ///    Dauerauftrag einrichten
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDAE,
        ///<summary>
        ///    Dauerauftrag löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDAL,
        ///<summary>
        ///    Dauerauftrag ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDAN,
        ///<summary>
        ///    Bestand terminierter SEPA-Sammellastschriften anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDBM,
        ///<summary>
        ///    Bestand terminierter SEPA Einzellastschriften anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDBS,
        ///<summary>
        ///    FinTS SEPA Bestand rückgabefähiger Lastschriften
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSB,
        ///<summary>
        ///    Terminierte SEPA-COR1-Einzellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSC,
        ///<summary>
        ///    SEPA-Lastschriftwiderspruch einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDSW,
        ///<summary>
        ///    Terminierte SEPA-COR1-Sammellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDMC,
        ///<summary>
        ///    SEPA-Dauereinzellastschrift einrichten
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDDE,
        ///<summary>
        ///    SEPA-Dauereinzellastschrift ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDDN,
        ///<summary>
        ///    SEPA-Dauereinzellastschrift aussetzen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDDU,
        ///<summary>
        ///    SEPA-Dauereinzellastschriftänderungsvormerkungen abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDDA,
        ///<summary>
        ///    SEPA-Dauereinzellastschriftbestand andordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDDB,
        ///<summary>
        ///    SEPA-Dauereinzellastschriftbestand löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDDL,
        ///<summary>
        ///    Depotaufstellung anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDWP,
        ///<summary>
        ///    Depotumsätze anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKDWU,
        ///<summary>
        ///    Elektronischer Kontoauszug (camt), z. B. für Sammlerauflösung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKECA,
        ///<summary>
        ///    elektronischen Kontoauszug abholen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKEKA,
        ///<summary>
        ///    Elektronischen Kontoauszug beantragen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKEKB,
        ///<summary>
        ///    elektronischen Kontoauszug abholen PDF
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKEKP,
        ///<summary>
        ///    Dialogende
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKEND,
        ///<summary>
        ///    Finanzdatenformat anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFDA,
        ///<summary>
        ///    Bearbeitungsstatus Finanzdatenformat anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFDB,
        ///<summary>
        ///    Finanzdatenformatliste anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFDL,
        ///<summary>
        ///    Finanzdatenformat senden
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFDS,
        ///<summary>
        ///    Festgeldanlage ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFGA,
        ///<summary>
        ///    Festgeldbestand anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFGB,
        ///<summary>
        ///    Festgeldkonditionen anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFGK,
        ///<summary>
        ///    Festgeldneuanlage
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFGN,
        ///<summary>
        ///    Festgeldanlage prolongieren
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFGP,
        ///<summary>
        ///    Festgeldneuanlage widerrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFGW,
        ///<summary>
        ///    Festpreisorder (Eigenhandel)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKFPO,
        ///<summary>
        ///    Identifikation
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKIDN,
        ///<summary>
        ///    Terminierte SEPA-Instant Payment Sammelzahlung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKIPE,
        ///<summary>
        ///    SEPA-Instant Payment Sammelzahlung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKIPM,
        ///<summary>
        ///    Instant Payment Zahlung (Echtzeitüberweisung)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKIPZ,
        ///<summary>
        ///    Anforderung eines öffentlichen Schlüssels
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKISA,
        ///<summary>
        ///    SEPA-Instant Payment Sammelzahlung Status
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKISS,
        ///<summary>
        ///    Neue Kontoumsätze holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKKAN,
        ///<summary>
        ///    Übersicht Kontoauszüge holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKKAU,
        ///<summary>
        ///    Kontoumsätze holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKKAZ,
        ///<summary>
        ///    Kundenmeldung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKKDM,
        ///<summary>
        ///    Kontoinformation abrufen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKKIF,
        ///<summary>
        ///    Lastschrift
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKLAS,
        ///<summary>
        ///    Lastschriftwiderspruch
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKLSW,
        ///<summary>
        ///    Neuemission zeichnen (Neuemissionen)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKNEZ,
        ///<summary>
        ///    Orderanzeige anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKOAN,
        ///<summary>
        ///    PIN online ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKPAE,
        ///<summary>
        ///    Prepaid-Karte (Handy) aufladen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKPPD,
        ///<summary>
        ///    Statusprotokoll holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKPRO,
        ///<summary>
        ///    elektronische Quittung für den erfolgreichen Abruf von elektronischen Kontoauszügen senden
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKQTG,
        ///<summary>
        ///    Saldo holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSAL,
        ///<summary>
        ///    Sammellastschrift
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSLA,
        ///<summary>
        ///    Terminierte Sammellastschrift Bestand
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSLB,
        ///<summary>
        ///    Terminierte Sammellastschrift einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSLE,
        ///<summary>
        ///    Terminierte Sammellastschrift löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSLL,
        ///<summary>
        ///    SEPA-Kontoverbindung anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSPA,
        ///<summary>
        ///    Schlüsselsperre
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSSP,
        ///<summary>
        ///    Euro-Überweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSTP,
        ///<summary>
        ///    Sammelüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSUB,
        ///<summary>
        ///    Synchronisierungsnachricht
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKSYN,
        ///<summary>
        ///    TAN-Medien-Bestand anzeigen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTAB,
        ///<summary>
        ///    TAN-Generator an-/ummelden
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTAU,
        ///<summary>
        ///    TAN-Verbrauchsinformationen anfordern / Liste der bereits verwendeten TAN-Nummern anzeigen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTAZ,
        ///<summary>
        ///    TAN-Medium deaktivieren/löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTML,
        ///<summary>
        ///    Terminierte Sammelüberweisung Bestand
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTSB,
        ///<summary>
        ///    Terminierte Sammelüberweisung einreichen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTSE,
        ///<summary>
        ///    Terminierte Sammelüberweisung löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTSL,
        ///<summary>
        ///    Terminüberweisung ändern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTUA,
        ///<summary>
        ///    Bestand an Terminüberweisungen holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTUB,
        ///<summary>
        ///    Terminüberweisung einrichten
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTUE,
        ///<summary>
        ///    Terminüberweisung löschen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKTUL,
        ///<summary>
        ///    Einzelüberweisung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKUEB,
        ///<summary>
        ///    Umbuchung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKUMB,
        ///<summary>
        ///    Übersicht institutsverwalteter Aufträge
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKUTA,
        ///<summary>
        ///    Verarbeitungsvorbereitung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKVVB,
        ///<summary>
        ///    Willenserklärung des Kunden
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWEK,
        ///<summary>
        ///    Fondsorder (Fonds)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWFO,
        ///<summary>
        ///    Wertpapierdepotaufstellung holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWPD,
        ///<summary>
        ///    Depotumsätze holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWPU,
        ///<summary>
        ///    Wertpapierkursabfrage
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWPK,
        ///<summary>
        ///    Wertpapierorder (Aktien, Renten, Optionsscheine)
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWPO,
        ///<summary>
        ///    Wertpapierreferenznummern holen
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWPR,
        ///<summary>
        ///    Orderstreichung
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWPS,
        ///<summary>
        ///    Wertpapierstammdaten anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWSD,
        ///<summary>
        ///    Orderstatus anfordern
        ///</summary>
        ///<remarks>
        ///    Info is not Translated but taken from the FinTS spec.
        ///</remarks>
        HKWSO,
    }
}
