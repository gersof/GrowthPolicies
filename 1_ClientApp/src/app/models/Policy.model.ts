export class PolicyModel {
    constructor(
      public Id: number,
      public Name: string,
      public Description: string,
      public StartValidity: string,
      public CoverPeriod: string,
      public Price: string,
      public CoverageId: string,
      public RiskId: string,
    ) {}
  }
  