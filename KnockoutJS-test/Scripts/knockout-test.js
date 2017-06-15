function AppViewModel() {
       
    var self = this;
    this.message = ko.observable("Test");
    this.message2 = message2;

    $.get("/api/api/", function (data) {
        
        self.message(data);
    });   

}

ko.applyBindings(new AppViewModel());