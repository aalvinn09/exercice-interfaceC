var facture = new Facture("F001", 250m);

IImprimable imprimable = facture;
IExportable exportable = facture;

imprimable.Imprimer();
exportable.Exporter("facture");

var rapport = new Rapport("Rapport annuel");

rapport.Exporter("rapport");