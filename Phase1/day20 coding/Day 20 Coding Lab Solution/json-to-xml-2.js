//import { json2xml } from 'xml-j

var json2xml = require('json2xml');
var fs = require('fs');


var jsonObj = JSON.parse(fs.readFileSync('output.json'));
var totalTests = 0;
var totalPass = 0;
var totalFail = 0;
//console.log(jsonObj.testResults[0].assertionResults);
for(var i = 0; i <= 2; i++){
  console.log(jsonObj.testResults[0].assertionResults[i].fullName + " - " + jsonObj.testResults[0].assertionResults[i].status);
  if( jsonObj.testResults[0].assertionResults[i].status === 'failed' ){
    totalFail++;
  }
  else{
    totalPass++;
  }
  totalTests++;
}

//creating xml file
var builder = require('xmlbuilder');
var doc = builder.create('root');


doc.ele('test-suite')
    .ele('test-case')
      .ele('name')
        .txt(jsonObj.testResults[0].assertionResults[0].fullName)
      .up()
      .ele('result')
        .txt(jsonObj.testResults[0].assertionResults[0].status)  
      .up()
    .up()
    .ele('test-case')
      .ele('name')
        .txt(jsonObj.testResults[0].assertionResults[1].fullName)
      .up()
      .ele('result')
        .txt(jsonObj.testResults[0].assertionResults[1].status)  
      .up()
    .up()
    .ele('test-case')
      .ele('name')
        .txt(jsonObj.testResults[0].assertionResults[2].fullName)
      .up()
      .ele('result')
        .txt(jsonObj.testResults[0].assertionResults[2].status)  
      .up()
    .up()
    .ele('summary')
      .ele('total-tests')
        .txt(totalTests)
      .up()
      .ele('total-pass')
        .txt(totalPass)
      .up()
      .ele('total-fail')
        .txt(totalFail)
      .up()
    .up()
  .up()
  //console.log(doc.toString({ pretty: true }));


fs.writeFile('output.xml', doc.toString(), err => {
    if (err) {
      console.error(err);
    } else {
      console.log("Success");
    }
  });