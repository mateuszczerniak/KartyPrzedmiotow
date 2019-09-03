
var options = {};
var extend = {};
extend["{root}.Godziny[i]"] = function (that) {
    that.StacjonarneEcts = ko.computed(function () {
        return (that.Stacjonarne() / 30).toFixed(1);
    })
    that.NiestacjonarneEcts = ko.computed(function () {
        return (that.Niestacjonarne() / 30).toFixed(1);
    })

    that.krotkaNazwa = ko.computed(function () {
        var nazwa = that.Nazwa().split('/');
        var krotka = "";
        for (var i = 0; i < nazwa.length; i++) {
            if (i > 0)
                krotka += '/';
            krotka += nazwa[i].substring(0, 1);
        }
        return krotka;
    })
    that.usunTrescGodziny = function () {
        if (that.Tresci().length > 1) {
            that.Tresci.remove(this);
            $('.selectpicker').selectpicker('refresh');
        }
    }
    that.dodajTrescGodziny = function () {
        var tesci = that.Tresci();
        var skrot = 1;
        if (tesci.length) {
            var last = tesci[tesci.length - 1];
            skrot = last.Skrot() + 1;
        }
        that.Tresci.push({ Nazwa: ko.observable(""), Skrot: ko.observable(skrot), krotkaNazwa: that.krotkaNazwa })
    }
    var tresci = that.Tresci();
    for (var i = 0; i < tresci.length; i++) {
        tresci[i].krotkaNazwa = that.krotkaNazwa;
    }
}
extend["{root}.Efekty[i]"] = function (that) {
    that.LiczbaTresci = ko.computed(function () {
        var suma = 0;
        var godziny = that.Godziny();
        for (var i = 0; i < godziny.length; i++) {
            suma += godziny[i].WybraneTresci().length ? 1 : 0;
        }
        if (suma >= 3)
            return '***';
        if (suma === 2)
            return '**';
        if (suma === 1)
            return '*';
        return '';
    })
}
extend["{root}.FormaPracy[i]"] = function (that) {
    that.dzienneRazem = ko.computed(function () {
        var dzienne = that.Dzienne();
        var razem = 0;
        for (var i = 0; i < dzienne.length; i++) {
            razem += Number(dzienne[i].Godzin());
        }
        return razem;
    });
    that.zaoczneRazem = ko.computed(function () {
        var zaoczne = that.Zaoczne();
        var razem = 0;
        for (var i = 0; i < zaoczne.length; i++) {
            razem += Number(zaoczne[i].Godzin());
        }
        return razem;
    });
    that.dzienneRazemEcts = ko.computed(function () {
        return (Number(that.dzienneRazem()) / 30).toFixed(1);
    })
    that.zaoczneRazemEcts = ko.computed(function () {
        return (Number(that.zaoczneRazem()) / 30).toFixed(1);
    })
}


extend["{root}.FormaPracy[i].Dzienne[i]"] = function (that) {
    that.Godzin.subscribe(function (val) {
        if (Number(val) < 0)
            that.Godzin(0);
        if (isNaN(val))
            that.Godzin(0);
        if (val === '')
            that.Godzin(0);
    });

    that.ects = ko.computed(function () {
        return (Number(that.Godzin()) / 30).toFixed(1);
    })
}
extend["{root}.FormaPracy[i].Zaoczne[i]"] = function (that) {
    that.Godzin.subscribe(function (val) {
        if (Number(val) < 0)
            that.Godzin(0);
        if (isNaN(val))
            that.Godzin(0);
        if (val === '')
            that.Godzin(0);
    });

    that.ects = ko.computed(function () {
        return (Number(that.Godzin()) / 30).toFixed(1);
    })
}

extend["{root}"] = function (that) {
    that.dzienneRazem = ko.computed(function () {
        var forma = that.FormaPracy();
        var razem = 0;
        for (var i = 0; i < forma.length; i++) {
            razem += forma[i].dzienneRazem()
        }
        return razem;
    })
    that.zaoczneRazem = ko.computed(function () {
        var forma = that.FormaPracy();
        var razem = 0;
        for (var i = 0; i < forma.length; i++) {
            razem += forma[i].zaoczneRazem()
        }
        return razem;
    })

    that.zNauczycielemRazemStacjonarne = ko.computed(function () {
        var godziny = that.Godziny();
        var suma = 0;
        for (var i = 0; i < godziny.length; i++) {
            suma += godziny[i].Stacjonarne();
        }
        return suma;
    })

    that.zNauczycielemRazemStacjonarneEcts = ko.computed(function () {
        return (that.zNauczycielemRazemStacjonarne() / 30).toFixed(1);
    })

    that.zNauczycielemRazemNiestacjonarne = ko.computed(function () {
        var godziny = that.Godziny();
        var suma = 0;
        for (var i = 0; i < godziny.length; i++) {
            suma += godziny[i].Niestacjonarne();
        }
        return suma;
    })

    that.zNauczycielemRazemNiestacjonarneEcts = ko.computed(function () {
        return (that.zNauczycielemRazemNiestacjonarne() / 30).toFixed(1);
    })
    that.dodajLiteraturyPodstawowe = function () {
        that.LiteraturyPodstawowe.push({ Nazwa: ko.observable("") });
    }
    that.usunLiteraturyPodstawowe = function () {
        if (that.LiteraturyPodstawowe().length > 1)
            that.LiteraturyPodstawowe.remove(this);
    }
    that.dodajLiteraturyUzupelniajace = function () {
        that.LiteraturyUzupelniajace.push({ Nazwa: ko.observable("") });
    }
    that.usunLiteraturyUzupelniajace = function () {
        if (that.LiteraturyUzupelniajace().length > 1)
            that.LiteraturyUzupelniajace.remove(this);
    }
    that.dodajZrodlaDodatkowe = function () {
        that.ZrodlaDodatkowe.push({ Nazwa: ko.observable("") });
    }
    that.usunZrodlaDodatkowe = function () {
        if (that.ZrodlaDodatkowe().length > 1)
            that.ZrodlaDodatkowe.remove(this);
    }
    that.dodajMetodyPodajaceIds = function () {
        var metody = that.MetodyPodajaceIds();
        var skrot = 1;
        if (metody.length) {
            var last = metody[metody.length - 1];
            skrot = last.Skrot() + 1;
        }
        that.MetodyPodajaceIds.push({ MetodaId: ko.observable(), Skrot: ko.observable(skrot) });
    }
    that.usunMetodyPodajaceIds = function () {
        that.MetodyPodajaceIds.remove(this);
    }
    that.dodajMetodyPraktyczneIds = function () {
        var metody = that.MetodyPraktyczneIds();
        var skrot = 1;
        if (metody.length) {
            var last = metody[metody.length - 1];
            skrot = last.Skrot() + 1;
        }
        that.MetodyPraktyczneIds.push({ MetodaId: ko.observable(), Skrot: ko.observable(skrot) });
    }
    that.usunMetodyPraktyczneIds = function () {
        that.MetodyPraktyczneIds.remove(this);
    }
    that.dodajMetodyProblemoweIds = function () {
        var metody = that.MetodyProblemoweIds();
        var skrot = 1;
        if (metody.length) {
            var last = metody[metody.length - 1];
            skrot = last.Skrot() + 1;
        }
        that.MetodyProblemoweIds.push({ MetodaId: ko.observable(), Skrot: ko.observable(skrot) });
    }
    that.usunMetodyProblemoweIds = function () {
        that.MetodyProblemoweIds.remove(this);
    }
    that.dodajMetodyEksponujaceIds = function () {
        var metody = that.MetodyEksponujaceIds();
        var skrot = 1;
        if (metody.length) {
            var last = metody[metody.length - 1];
            skrot = last.Skrot() + 1;
        }
        that.MetodyEksponujaceIds.push({ MetodaId: ko.observable(), Skrot: ko.observable(skrot) });
    }
    that.usunMetodyEksponujaceIds = function () {
        that.MetodyEksponujaceIds.remove(this);
    }
    that.dodajMetodyOcenianiaIds = function () {
        var metody = that.MetodyOcenianiaIds();
        var skrot = 1;
        if (metody.length) {
            var last = metody[metody.length - 1];
            skrot = last.Skrot() + 1;
        }
        that.MetodyOcenianiaIds.push({ MetodaId: ko.observable(), Skrot: ko.observable(skrot) });
    }
    that.usunMetodyOcenianiaIds = function () {
        that.MetodyOcenianiaIds.remove(this);
    }
    that.dodajPytania = function () {
        that.Pytania.push({ Nazwa: ko.observable("") });
    }
    that.usunPytania = function () {
        if (that.Pytania().length > 1)
            that.Pytania.remove(this);
    }
}

options.extend = extend;

var viewmodel = ko.viewmodel.fromModel(model, options);


var efektyList = viewmodel.Efekty();
for (var i = 0; i < efektyList.length; i++) {
    var godzinyList = efektyList[i].Godziny();
    for (var j = 0; j < godzinyList.length; j++) {
        var typLiczbaGodzinId = godzinyList[j].TypLiczbaGodzinId();

        (function (typLiczbaGodzinId) {
            godzinyList[j].Tresci = ko.computed(function () {
                var godziny = viewmodel.Godziny();
                var godzina = godziny.find(function (godzina) {
                    return godzina.TypLiczbaGodzinId() === typLiczbaGodzinId;
                })
                var tresci = godzina.Tresci();
                return tresci;
            });
        })(typLiczbaGodzinId);
    }

    efektyList[i].MetodyPodajace = ko.computed(function () {
        return viewmodel.MetodyPodajaceIds();
    })

    efektyList[i].MetodyPraktyczne = ko.computed(function () {
        return viewmodel.MetodyPraktyczneIds();
    })

    efektyList[i].MetodyProblemowe = ko.computed(function () {
        return viewmodel.MetodyProblemoweIds();
    })

    efektyList[i].MetodyEksponujace = ko.computed(function () {
        return viewmodel.MetodyEksponujaceIds();
    })

    efektyList[i].MetodyOceniania = ko.computed(function () {
        return viewmodel.MetodyOcenianiaIds();
    })
}

viewmodel.FormaPracySumyDzienne = ko.computed(function () {
    var godziny = viewmodel.Godziny();
    var models = [];
    for (var i = 0; i < godziny.length; i++) {
        var model = {};
        (function (id) {
            model.suma = ko.computed(function () {
                var sum = 0;
                var forma = viewmodel.FormaPracy();
                for (var j = 0; j < forma.length; j++) {
                    sum += Number(forma[j].Dzienne()[id].Godzin())
                }
                return sum + viewmodel.Godziny()[id].Stacjonarne();
            });
        })(i);
        models.push(model);
    }
    return models;
});

viewmodel.FormaPracySumyZaoczne = ko.computed(function () {
    var godziny = viewmodel.Godziny();
    var models = [];
    for (var i = 0; i < godziny.length; i++) {
        var model = {};
        (function (id) {
            model.suma = ko.computed(function () {
                var sum = 0;
                var forma = viewmodel.FormaPracy();
                for (var j = 0; j < forma.length; j++) {
                    sum += Number(forma[j].Zaoczne()[id].Godzin())
                }
                return sum + viewmodel.Godziny()[id].Niestacjonarne();
            });
        })(i);
        models.push(model);
    }
    return models;
});

viewmodel.dzienneRazemFull = ko.computed(function () {
    return viewmodel.dzienneRazem() + viewmodel.zNauczycielemRazemStacjonarne();
});

viewmodel.zaoczneRazemFull = ko.computed(function () {
    return viewmodel.zaoczneRazem() + viewmodel.zNauczycielemRazemNiestacjonarne();
});

viewmodel.dzienneRazemEcts = ko.computed(function () {
    return (Number(viewmodel.dzienneRazemFull()) / 30).toFixed(1);
})
viewmodel.zaoczneRazemEcts = ko.computed(function () {
    return (Number(viewmodel.zaoczneRazemFull()) / 30).toFixed(1);
})
viewmodel.dzienneRazemEctsMax = ko.computed(function () {
    return (Number(viewmodel.dzienneRazemFull()) / 25).toFixed(1);
})
viewmodel.zaoczneRazemEctsMax = ko.computed(function () {
    return (Number(viewmodel.zaoczneRazemFull()) / 25).toFixed(1);
})


viewmodel.save = function () {
    var data = ko.viewmodel.toModel(viewmodel);
    $.post(saveURL, data, function (returnedData) {
        if (!returnedData.success)
            alert("Błąd podczas zapisywania zmian");
        window.location.href = homeURL;
    })
}

ko.applyBindings(viewmodel);

$(document).on('click', '.selectpicker-button button', function () {
    $(this).siblings('select').selectpicker('refresh');
})