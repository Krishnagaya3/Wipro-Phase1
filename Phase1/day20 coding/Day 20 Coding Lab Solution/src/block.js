import React, { PureComponent } from 'react';

class Block extends PureComponent {
  render() {
    return (
      <div>
        <h1>{this.props.name}</h1>
        <p>{this.props.count}</p>
      </div>
    );
  }
}

export default Block;