const Jasmine = require("jasmine");
const SpecReporter = require("jasmine-spec-reporter").SpecReporter;

const jasmine = new Jasmine();

jasmine.configureDefaultReporter({
  print() {}
});

jasmine.addReporter(
  new SpecReporter({
    spec: {
      displayPending: true
    }
  })
);

jasmine.loadConfigFile("./spec/jasmine.json");
jasmine.execute();
