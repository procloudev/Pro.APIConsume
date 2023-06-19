import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
      this.state = { facilityServices: [], paymentMethods: [], loading: true };
  }

  componentDidMount() {
    this.populateHSLAPIData();
  }

    static renderHSLTable(facilityServices) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Services</th>
            
          </tr>
        </thead>
        <tbody>
          {facilityServices.map(fservice =>
            <tr key={fservice}>
              <td>{fservice}</td>
             
            </tr>
          )}
        </tbody>
      </table>
    );
  }

   static renderHSLTable2(paymentMethods) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>PaymentMethods</th>
            
          </tr>
        </thead>
        <tbody>
          {paymentMethods.map(pmethods =>
            <tr key={pmethods}>
              <td>{pmethods}</td>
             
            </tr>
          )}
        </tbody>
      </table>
    );
  }
  render() {
      let contents = this.state.loading
          ? <p><em>Loading...</em></p>
          : FetchData.renderHSLTable(this.state.facilityServices);

      let contents2 = this.state.loading
          ? <p><em>Loading...</em></p>
          : FetchData.renderHSLTable2(this.state.paymentMethods);

    return (
      <div>
        <h1 id="tabelLabel" >HSL Ride and Park API Data</h1>
        <p>This component demonstrates fetching data from the server.</p>
            {contents}
            {contents2}
      </div>
    );
  }

  async populateHSLAPIData() {
    const response1 = await fetch('/parkandride/api/services');
    const data1 = await response1.json();

      const response2 = await fetch('/parkandride/api/paymentmethods');
      const data2 = await response2.json();

      this.setState({ facilityServices: data1, paymentMethods: data2, loading: false });
  }
}
