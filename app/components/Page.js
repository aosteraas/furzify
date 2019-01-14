import React from 'react';
import styled, { ThemeProvider, createGlobalStyle } from 'styled-components';
import { Meta, Header } from './';

const theme = {
  red: '#FF0000',
  black: '#393939',
  grey: '#3A3A3A',
  lightgrey: '#E1E1E1',
  offWhite: '#EDEDED',
  maxWidth: '1000px'
};
const StyledPage = styled.div`
  color: white;
  background: ${props => props.theme.black};
`;

const GlobalStyle = createGlobalStyle`
  html {
    box-sizing: border-box;
    font-size: 10px;
  }
  *, *:before, *:after {
    box-sizing: inherit;
  }
  body {
    padding: 0;
    margin: 0;
    font-size: 1.5rem;
    line-height: 2;
    font-family: Helvetica, Arial, sans-serif;
  }
  a {
    text-decoration: none;
    color: ${theme.red};
  }
`;

export class Page extends React.Component {
  render() {
    return (
      <ThemeProvider theme={theme}>
        <StyledPage>
          <Meta />
          <GlobalStyle />
          <Header />
          {this.props.children}
        </StyledPage>
      </ThemeProvider>
    );
  }
}
